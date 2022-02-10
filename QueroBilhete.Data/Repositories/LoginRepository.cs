using QueroBilhete.Data.Repositories;
using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;

namespace QueroBilhete.Infra.Data.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        private readonly IBaseRepository _repositorio;
        public LoginRepository(IBaseRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public Login Logar(string email, string senha)
        {
            return _repositorio.BuscarPorQueryGerador<Login>($"EMAIL = '{email}' AND SENHA = '{senha}'");
        }
    }
}
