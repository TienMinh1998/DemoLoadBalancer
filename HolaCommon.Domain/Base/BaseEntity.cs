using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolaCommon.Domain.Base
{
    public abstract class BaseEntity
    {
    }

    public abstract class BaseEntity<TKey> : BaseEntity
    {
        [Key]
        public TKey Id { get; set; }
    }
}
