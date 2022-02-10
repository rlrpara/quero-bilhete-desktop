using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Infra.Data.Repositories;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;

namespace QueroBilhete.Service.Service
{
    public class LoginService : BaseService, ILoginService
    {
        private readonly LoginRepository _loginRepository;

        public LoginService(IBaseRepository repositorio)
            : base(repositorio)
        {
            _loginRepository = new LoginRepository(repositorio);
        }

        public LoginViewModel logar(string email, string senha)
        {
            var login = _loginRepository.logar(email, senha);
            if (login == null) return null;
            else
            {
                return new LoginViewModel
                {
                    Codigo = (int)(login.Codigo > 0 ? login.Codigo : 0),
                    Email = login.Email,
                    Senha = login.Senha
                };
           }
        }
    }
}
