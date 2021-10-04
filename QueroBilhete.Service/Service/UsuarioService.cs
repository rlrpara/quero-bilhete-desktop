using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;

namespace QueroBilhete.Service.Service
{
    public class UsuarioService : BaseService<UsuarioViewModel>, IUsuarioService<UsuarioViewModel>
    {
        public UsuarioService(IBaseRepository<UsuarioViewModel> repository) : base(repository)
        {
        }
    }
}
