using System.Threading.Tasks;

namespace BookMarker.Core.Infra.Email
{
    public class EnvioEmail : IEnvioEmail
    {
        public async Task EnviarAsync(string nome, string email, string assunto, string mensagem)
        {
            await Task.FromResult(0);
        }
    }
}

