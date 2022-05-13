using System.ComponentModel.DataAnnotations;

namespace HolaCommon.API.DTOs.Currencies
{
    public class EditCurrencyResponse
    {
        [Required]
        public short CurrencyId { get; set; }

        [Required]
        [StringLength(5)]
        public string Code { get; set; }

        [Required]
        [StringLength(5)]
        public string Symbol { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(5)]
        public string Number { get; set; }

        [Required]
        public decimal MinAmount { get; set; }

        [Required]
        public decimal MaxAmount { get; set; }

        [Required]
        [StringLength(100)]
        public string Units { get; set; }
    }
}
