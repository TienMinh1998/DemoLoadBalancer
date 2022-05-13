namespace HolaCommon.API.DTOs.Country
{
    public class GetCountryListResponse
    {
        public short CountryId { get; set; }
        public short CurrencyId { get; set; }
        public string Name { get; set; }
        public string PhoneCode { get; set; }
        public string PhonePattern { get; set; }
        public string ISO2 { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
