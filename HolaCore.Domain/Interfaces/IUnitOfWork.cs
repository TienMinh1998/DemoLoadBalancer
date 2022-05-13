using HolaCore.Domain.Base;
using System.Threading.Tasks;

namespace HolaCore.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity;
    }
}
