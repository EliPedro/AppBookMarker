using BookMarker.Domain.Leitores.ValueObject;
using System;

namespace BookMarker.Domain.Leitores
{
    public class Endereco
    {
        public String   EnderecoId { get; set; }
        public String Logradouro { get; set; }
        public String Cidade     { get; set; }
        public String Estado     { get; set; }
        public Cep    Cep        { get; private set; }

        public Endereco(Cep cep)
        {
            EnderecoId = Guid.NewGuid().ToString();
            Cep = cep;
        }

        public Boolean EhValidoEndereco()
        {
            if (String.IsNullOrEmpty(Estado) || String.IsNullOrEmpty(Cidade)) return false;

            return true;
        }
    }
}