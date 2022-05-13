using HolaCommon.API.DTOs.Country;
using HolaCommon.Domain.Entities.Countries;
using HolaCommon.Domain.Interfaces;

namespace HolaCommon.API.Services.Countries
{
    public class CountryService : BaseService
    {
        public CountryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<GetCountryListResponse>> SearchAsync(GetCountryListRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<Country>();
            var country = await repository
                .ListAsync(_ => _.Name.Contains(request.Search) || _.PhoneCode.Contains(request.Search));

            var countryDTOs = country.Select(_ => new GetCountryListResponse()
            {
                CountryId = _.Id,
                CurrencyId = _.CurrencyId,
                Name = _.Name,
                PhoneCode = _.PhoneCode,
                PhonePattern = _.PhonePattern,
                ISO2 = _.ISO2,
                CreatedDate = _.CreatedDate,
                CreatedBy = _.CreatedBy,
                ModifiedDate = _.ModifiedDate,
                ModifiedBy = _.ModifiedBy
            })
            .ToList();

            return countryDTOs;
        }
    }
}
