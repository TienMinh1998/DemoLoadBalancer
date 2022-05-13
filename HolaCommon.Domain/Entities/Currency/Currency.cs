using HolaCommon.Domain.Base;
using HolaCommon.Domain.Entities.Countries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolaCommon.Domain.Entities.Currencies
{
    [Table("Currency", Schema = "cmn")]
    public partial class Currency : BaseEntity<short>
    {
        [Column("Code", TypeName = "varchar")]
        [StringLength(5)]
        public string Code { get; set; }

        [Column("Symbol", TypeName = "varchar")]
        [StringLength(5)]
        public string Symbol { get; set; }

        [Column("Description", TypeName = "varchar")]
        [StringLength(50)]
        public string Description { get; set; }

        [Column("Number", TypeName = "varchar")]
        [StringLength(5)]
        public string Number { get; set; }

        [Column("MinAmount", TypeName = "decimal(19, 4)")]
        public decimal MinAmount { get; set; }

        [Column("MaxAmount", TypeName = "decimal(19, 4)")]
        public decimal MaxAmount { get; set; }

        [Column("Units", TypeName = "varchar")]
        [StringLength(100)]
        public string Units { get; set; }

        public List<Country> Country { get; set; }
    }
}
