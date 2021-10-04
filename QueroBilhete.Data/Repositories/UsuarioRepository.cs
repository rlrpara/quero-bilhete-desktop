using QueroBilhete.Domain.Entities;
using QueroBilhete.Domain.Interfaces;

namespace QueroBilhete.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository()
        {
        }
    }
}
