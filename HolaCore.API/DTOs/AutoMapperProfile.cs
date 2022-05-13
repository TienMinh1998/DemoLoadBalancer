using AutoMapper;
using HolaCore.API.DTOs.Users;
using HolaCore.Domain.Entities.Users;

namespace HolaCore.API.DTOs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region User
            CreateMap<User, GetUserListRequest>();
            #endregion
        }
    }
}
