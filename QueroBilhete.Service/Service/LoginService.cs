using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;
using System;

namespace QueroBilhete.Service.Service
{
    public class LoginService : BaseService, ILoginService
    {
        public LoginService(IBaseRepository repositorio)
            : base(repositorio)
        {
        }

        public LoginViewModel logar(string email, string senha)
        {
            var loginViewModel = new LoginViewModel();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
                return loginViewModel;

            var login = _baseRepository.BuscarPorQueryGerador<Login>($"EMAIL = '{email}' AND SENHA = '{senha}'");

            if(login != null)
            {
                loginViewModel.Email = login.Email;
                loginViewModel.Senha = login.Senha;
            }

            return loginViewModel;

        }
    }
}
