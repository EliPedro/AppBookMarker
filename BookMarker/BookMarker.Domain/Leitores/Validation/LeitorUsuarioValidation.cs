using BookMarker.Core.Domain.Validation;

namespace BookMarker.Domain.Leitores.Validation
{
    public class LeitorUsuarioValidation : AbstractValidator<LeitorUsuario>
    {
        public override void Validate()
        {
            var msg = Obj.EhValidaSenha();

            if (!string.IsNullOrEmpty(msg))
                Errors.Add(new ValidationMessage(msg));

        }
    }
}
