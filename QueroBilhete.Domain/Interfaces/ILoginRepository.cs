using QueroBilhete.Domain.Entities;

namespace QueroBilhete.Domain.Interfaces
{
    public interface ILoginRepository : IBaseRepository
    {
        Login logar(string email, string senha);
    }
}
