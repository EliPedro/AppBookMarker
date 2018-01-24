using System;
using System.Text.RegularExpressions;

namespace BookMarker.Domain.Leitores
{
    public class LeitorUsuario
    {
        public String UsuarioId { get; private set; }
        public String Login     { get; private set; }
        public String Senha     { get; private set; }
        public Leitor Leitor    { get; private set; }

        public LeitorUsuario()
        {
            UsuarioId = Guid.NewGuid().ToString();
        }

        public String EhValidaSenha()
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,6}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(Senha))
            {
                return "A senha deve conter pelo menos uma letra minúscula";
            }
            else if (!hasUpperChar.IsMatch(Senha))
            {
                return "A senha deve conter pelo menos uma letra maiúscula.";
            }
            else if (!hasMiniMaxChars.IsMatch(Senha))
            {
                return "A senha não deve ser inferior ou superior a 6 caracteres";
            }
            else if (!hasNumber.IsMatch(Senha))
            {
                return "A senha deve conter pelo menos um valor numérico.";
            }

            else if (!hasSymbols.IsMatch(Senha))
            {
                return "A senha deve conter pelo menos um caracter especial.";
            }
            else
            {
                return String.Empty;
            }
        }
    }
}