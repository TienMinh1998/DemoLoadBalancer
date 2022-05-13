using HolaCore.Domain.Entities.Users;

namespace HolaCore.Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>
        , IUserRepository
    {
        public UserRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
