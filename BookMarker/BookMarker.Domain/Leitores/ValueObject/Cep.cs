using System;

namespace BookMarker.Domain.Leitores.ValueObject
{
    public class Cep
    {
        public String Codigo { get; private set; }

        public Cep(String codigo)
        {
            Codigo = codigo;
        }

        public Boolean EhValidoCep()
        {
            FormatarCep();

            if (Codigo.Length != 8) return false;

            return true;
        }

        public void FormatarCep()
        {
            Codigo += Codigo.Replace("-","").Replace(".","");
        }
    }
}