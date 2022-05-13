using HolaCommon.Domain.Entities.Currencies;

namespace HolaCommon.Infrastructure.Data.Repositories
{
    public class CurrencyRepository : RepositoryBase<Currency>
        , ICurrencyRepository
    {
        public CurrencyRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
