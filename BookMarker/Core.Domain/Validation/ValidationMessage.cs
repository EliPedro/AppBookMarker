using System;

namespace BookMarker.Core.Domain.Validation
{
    public class ValidationMessage
    {
        public String Message { get; private set; }
        public ValidationMessage(String message)
        {
            Message = message;
        }
    }
}
