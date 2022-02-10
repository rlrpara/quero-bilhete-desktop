using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Infra.Data.Repositories;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;

namespace QueroBilhete.Service.Service
{
    public class LoginService : BaseService, ILoginService
    {
        #region [Propriedades Privadas]
        private readonly LoginRepository _loginRepository;
        #endregion

        #region [Construtor]
        public LoginService(IBaseRepository repositorio) : base(repositorio)
        {
            _loginRepository = new LoginRepository(repositorio);
        }
        #endregion

        #region [Métodos Públicos]
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
        #endregion
    }
}
