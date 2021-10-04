using QueroBilhete.Data.Repositories;
using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;

namespace QueroBilhete.Infra.Data.Repositories
{
    public class LoginRepository : BaseRepository<Login>, ILoginRepository
    {
        private readonly IBaseRepository<Login> _repositorio;
        public LoginRepository(IBaseRepository<Login> repositorio)
        {
            _repositorio = repositorio;
        }

        public Login logar(string email, string senha)
        {
            return _repositorio.BuscarPorQueryGerador($"EMAIL = {email} AND SENHA = {senha}");
        }
    }
}
