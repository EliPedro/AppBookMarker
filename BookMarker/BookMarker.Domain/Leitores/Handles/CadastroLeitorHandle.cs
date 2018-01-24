using System.Collections.Generic;
using BookMarker.Core.Domain.Handles;
using BookMarker.Domain.Leitores.Events;
using BookMarker.Core.Infra.Email;

namespace BookMarker.Domain.Leitores.Handles
{
    public class CadastroLeitorHandle : IHandler<CadastroLeitorEvent>
    {
        private readonly IEnvioEmail _envioEmail;
        private List<CadastroLeitorEvent> _notifications;
        public CadastroLeitorHandle(IEnvioEmail envioEmail)
        {
            _envioEmail = envioEmail;
        }
        
        public void Handle(CadastroLeitorEvent args)
        {
           _envioEmail.EnviarAsync(args.Leitor.Nome,
                                    args.Leitor.Email.Endereco, 
                                    args.EmailTitle,
                                    args.EmailBody);
        }
    }
}
