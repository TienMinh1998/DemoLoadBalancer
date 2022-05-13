using AutoMapper;
using HolaCore.API.DTOs.Users;
using HolaCore.Domain.Entities.Users;
using HolaCore.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolaCore.API.Services.Users
{
    public class UserService : BaseService
    {
        private readonly IMapper mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this.mapper = mapper;
        }

        public async Task<List<GetUserListResponse>> SearchAsync(GetUserListRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<User>();
            var users = await repository
                .ListAsync(_ => _.Username.Contains(request.Search));

            return mapper.Map<List<GetUserListResponse>>(users);
        }
    }
}
