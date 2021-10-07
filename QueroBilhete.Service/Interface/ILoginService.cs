using QueroBilhete.Service.ViewModels;

namespace QueroBilhete.Service.Interface
{
    public interface ILoginService : IBaseService
    {
        LoginViewModel logar(string email, string senha);
    }
}
