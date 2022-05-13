using HolaCore.Domain.Interfaces;

namespace HolaCore.Domain.Entities.Users
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}
