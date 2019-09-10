using System.Threading.Tasks;

namespace BaseConhecimentoApi.Infra.Identity.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
