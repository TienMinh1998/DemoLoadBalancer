using System.ComponentModel.DataAnnotations;

namespace HolaCommon.API.DTOs.Currencies
{
    public class EditCurrencyRequest
    {
        [Required]
        public short Id { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        [StringLength(5)]
        public string Symbol { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(5)]
        public string Number { get; set; }

        public decimal MinAmount { get; set; }

        public decimal MaxAmount { get; set; }

        [StringLength(100)]
        public string Units { get; set; }
    }
}
