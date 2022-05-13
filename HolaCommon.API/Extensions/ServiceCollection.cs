using HolaCommon.API.Services.Countries;
using HolaCommon.API.Services.Currencies;
using HolaCommon.Domain.Entities.Countries;
using HolaCommon.Domain.Entities.Currencies;
using HolaCommon.Domain.Interfaces;
using HolaCommon.Infrastructure.Data;
using HolaCommon.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HolaCommon.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))
                .AddScoped<ICountryRepository, CountryRepository>()
                .AddScoped<ICurrencyRepository, CurrencyRepository>(); ;
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<EFContext>(options =>
                     options.UseNpgsql(configuration.GetConnectionString("HolaCommonConnectionString")));
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services
           )
        {
            return services
                .AddScoped<CountryService>()
                .AddScoped<CurrencyService>();
        }
    }
}
