using HolaCore.Domain.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolaCore.Domain.Entities.Users
{
    [Table("User", Schema = "usr")]
    public partial class User : BaseEntity<Guid>
    {
        [Column("GalleryId", TypeName="bigint")]
        public long GalleryId { get; set; }

        [Column("CountryId", TypeName = "smallint")]
        public short CountryId { get; set; }

        [Column("LanguageId", TypeName = "smallint")]
        public short LanguageId { get; set; }

        [Column("Username", TypeName = "varchar")]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("Email", TypeName = "varchar")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("PinHash", TypeName = "varchar")]
        [StringLength(500)]
        public string PinHash { get; set; }

        [Column("PinVersion", TypeName = "varchar")]
        [StringLength(5)]
        public string PinVersion { get; set; }

        [Column("PasswordHash", TypeName = "varchar")]
        [StringLength(500)]
        public string PasswordHash { get; set; }

        [Column("PasswordVersion", TypeName = "varchar")]
        [StringLength(5)]
        public string PasswordVersion { get; set; }

        [Column("PhoneNumber", TypeName = "varchar")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column("PhoneNumberConfirmed", TypeName = "boolean")]
        public bool PhoneNumberConfirmed { get; set; }

        [Column("LastLoginAttemptDate", TypeName = "timestamp")]
        public DateTime LastLoginAttemptDate { get; set; }

        [Column("LockoutEnd", TypeName = "timestamp")]
        public DateTime LockoutEnd { get; set; }

        [Column("AccessFailedCount", TypeName = "smallint")]
        public short AccessFailedCount { get; set; }

        [Column("PasswordEnabled", TypeName = "boolean")]
        public bool PasswordEnabled { get; set; }

        [Column("TwoFactorEnabled", TypeName = "boolean")]
        public bool TwoFactorEnabled { get; set; }

        [Column("TwoFAProvider", TypeName = "integer")]
        public int TwoFAProvider { get; set; }

        [Column("Status", TypeName = "smallint")]
        public short Status { get; set; }

        [Column("CreateDate", TypeName = "timestamp")]
        public DateTime CreateDate { get; set; }
    }
}
