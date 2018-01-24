using System.Collections.Generic;

namespace BookMarker.Core.Domain.Validation
{
    public abstract class AbstractValidator<T> where T : class, new()
    {
        protected readonly T Obj;
        public static IList<ValidationMessage> Errors { get; private set; }

        public AbstractValidator()
        {
            Obj = new T();
            Errors = new List<ValidationMessage>();
        }

        public abstract void Validate();

        public static bool IsValid()
        {
            if (Errors.Count == 0) return true;

            return false;
        }

        public static void ClearErros()
        {
            Errors.Clear();
        }
    }
}
