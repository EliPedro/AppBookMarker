using BookMarker.Core.Domain.Validation;

namespace BookMarker.Domain.Leitores.Validation
{
    public class LeitorValidation : AbstractValidator<Leitor>
    {
        public override void Validate()
        {
            if (!Obj.Cpf.EhValidoCpf())
                Errors.Add(new ValidationMessage("CPF inválido!"));

            if (!Obj.Email.EhValidoEmail())
                Errors.Add(new ValidationMessage("E-mail inválido!"));

            if (!Obj.Endereco.Cep.EhValidoCep() || !Obj.Endereco.EhValidoEndereco())
                Errors.Add(new ValidationMessage("CEP inválido!"));         
        }
    }
}
