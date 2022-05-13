using HolaCommon.API.DTOs.Currencies;
using HolaCommon.Domain.Interfaces;
using HolaCommon.Domain.Entities.Currencies;
using AutoMapper;

namespace HolaCommon.API.Services.Currencies
{
    public class CurrencyService : BaseService
    {
        private readonly IMapper mapper;

        public CurrencyService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this.mapper = mapper;
        }

        public async Task<List<GetCurrencyListResponse>> SearchAsync(GetCurrencyListRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<Currency>();
            var currency = await repository
                .ListAsync(_ => _.Code.Contains(request.Search) || _.Symbol.Contains(request.Search));

            return mapper.Map<List<GetCurrencyListResponse>>(currency);
        }

        public async Task<GetCurrencyResponse> GetAsync(GetCurrencyRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<Currency>();
            var currency = await repository
                .GetAsync(_ => _.Id == request.CurrencyId);

            return mapper.Map<GetCurrencyResponse>(currency);
        }

        public async Task<AddCurrencyResponse> AddNewAsync(AddCurrencyRequest model)
        {
            Currency currency = mapper.Map<Currency>(model);

            var repository = UnitOfWork.AsyncRepository<Currency>();
            await repository.AddAsync(currency);
            await UnitOfWork.SaveChangesAsync();

            return mapper.Map<AddCurrencyResponse>(currency);
        }

        public async Task<EditCurrencyResponse> UpdateAsync(EditCurrencyRequest model)
        {
            Currency currency = mapper.Map<Currency>(model);

            var repository = UnitOfWork.AsyncRepository<Currency>();
            await repository.UpdateAsync(currency);
            await UnitOfWork.SaveChangesAsync();

            return mapper.Map<EditCurrencyResponse>(currency);
        }

        public async Task<bool> DeleteAsync(DeleteCurrencyRequest model)
        {
            Currency currency = mapper.Map<Currency>(model);

            var repository = UnitOfWork.AsyncRepository<Currency>();
            var result = await repository.DeleteAsync(currency);
            await UnitOfWork.SaveChangesAsync();

            return result;
        }
    }
}
