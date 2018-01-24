using System.Threading.Tasks;

namespace BookMarker.Core.Infra.Email
{
    public interface IEnvioEmail
    {
        Task EnviarAsync(string nome, string email, string assunto, string mensagem);
    }
}
