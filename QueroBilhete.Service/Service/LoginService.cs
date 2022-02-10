using QueroBilhete.Domain.Entities;
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

        public LoginViewModel Logar(string email, string senha)
        {
            Login login = _loginRepository.Logar(email, senha);

            if (login != null)
                return new LoginViewModel
                {
                    Codigo = (int)(login.Codigo > 0 ? login.Codigo : 0),
                    Email = login.Email,
                    Senha = login.Senha
                };

            return null;
        }
    }
}
