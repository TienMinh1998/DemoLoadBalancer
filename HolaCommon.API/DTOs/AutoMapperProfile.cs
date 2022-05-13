using AutoMapper;
using HolaCommon.API.DTOs.Currencies;
using HolaCommon.Domain.Entities.Currencies;

namespace HolaCommon.API.DTOs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Currency
            CreateMap<Currency, GetCurrencyListResponse>();
            CreateMap<Currency, GetCurrencyResponse>();
            CreateMap<AddCurrencyRequest, Currency>();
            CreateMap<Currency, AddCurrencyResponse>();
            CreateMap<EditCurrencyRequest, Currency>();
            CreateMap<Currency, EditCurrencyResponse>();
            CreateMap<DeleteCurrencyRequest, Currency>();
            #endregion
        }
    }
}
