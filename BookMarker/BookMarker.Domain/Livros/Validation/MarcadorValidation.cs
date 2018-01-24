using BookMarker.Domain.Marcadores;
using BookMarker.Core.Domain.Validation;

namespace BookMarker.Domain.Livros.Validation
{
    public class MarcadorValidation : AbstractValidator<Marcador>
    {
        public override void Validate()
        {
            if (!Obj.EhValidoNumeroPagina())
                Errors.Add(new ValidationMessage("Número de Página inválido!"));
        }
    }
}
