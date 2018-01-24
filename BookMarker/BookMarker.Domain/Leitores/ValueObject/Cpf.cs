using System;

namespace BookMarker.Domain.Leitores.ValueObject
{
    public class Cpf
    {
        public String Codigo { get; private set; }

        public Cpf(String codigo)
        {
            Codigo = codigo;
        }

        public bool EhValidoCpf()
        {

            var multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            Codigo = Codigo.Trim();
            Codigo = Codigo.Replace(".", "").Replace("-", "");

            if (Codigo.Length != 11)
                return false;

            tempCpf = Codigo.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; ++i)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int j = 0; j < 10; j++)
                soma += int.Parse(tempCpf[j].ToString()) * multiplicador2[j];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return Codigo.EndsWith(digito);
        }

        public void FormatarCpf()
        {
        }
    }
}