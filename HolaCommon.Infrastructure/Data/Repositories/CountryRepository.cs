using HolaCommon.Domain.Entities.Countries;

namespace HolaCommon.Infrastructure.Data.Repositories
{
    public class CountryRepository : RepositoryBase<Country>
        , ICountryRepository
    {
        public CountryRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
