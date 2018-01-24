using System;
using System.Text.RegularExpressions;

namespace BookMarker.Domain.Leitores.ValueObject
{
    public class Email
    {
        public string Endereco { get; private set; }

        public Email(String endereco)
        {
            Endereco = endereco;
        }
        public bool EhValidoEmail()
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\
                                       $%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?
                                       (\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)
                                       +[a-zA-Z]{2,6}))$");

            return regexEmail.IsMatch(Endereco);
        }
    }
}
