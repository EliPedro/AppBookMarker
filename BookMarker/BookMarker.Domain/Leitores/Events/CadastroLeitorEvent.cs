using BookMarker.Core.Domain.Events;

namespace BookMarker.Domain.Leitores.Events
{
    public class CadastroLeitorEvent : IDomainEvent
    {
        public Leitor Leitor     { get; private set; }
        public string EmailTitle { get; private set; }
        public string EmailBody  { get; private set; }
        public CadastroLeitorEvent(Leitor leitor)
        {
            this.Leitor = leitor;
            this.EmailBody = $"Seja bem vindo, {leitor.Nome} !!";
            this.EmailBody = "Obrigado!";
        } 
    }
}
