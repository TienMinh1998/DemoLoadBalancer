namespace HolaCommon.API.DTOs.Currencies
{
    public class AddCurrencyResponse
    {
        public short CurrencyId { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public string Units { get; set; }
    }
}
