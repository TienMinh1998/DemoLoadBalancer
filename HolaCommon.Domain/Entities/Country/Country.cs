using HolaCommon.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using HolaCommon.Domain.Entities.Currencies;
using System.ComponentModel.DataAnnotations;

namespace HolaCommon.Domain.Entities.Countries
{
    [Table("Country", Schema = "cmn")]
    public partial class Country : BaseEntity<short>
    {
        [ForeignKey("Currency")]
        [Column("CurrencyId", TypeName = "smallint")]
        public short CurrencyId { get; set; }

        [Column("Name", TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("PhoneCode", TypeName = "varchar")]
        [StringLength(20)]
        public string PhoneCode { get; set; }

        [Column("PhonePattern", TypeName = "varchar")]
        [StringLength(20)]
        public string PhonePattern { get; set; }

        [Column("ISO2", TypeName = "varchar")]
        [StringLength(2)]
        public string ISO2 { get; set; }

        [Column("CreatedDate", TypeName = "timestamp")]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "timestamp")]
        public DateTime ModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ModifiedBy { get; set; }

        public Currency Currency { get; set; }
    }
}
