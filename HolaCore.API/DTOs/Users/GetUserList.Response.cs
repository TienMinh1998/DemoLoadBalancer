using System;

namespace HolaCore.API.DTOs.Users
{
    public class GetUserListResponse
    {
        public Guid UserId { get; set; }
        public long GalleryId { get; set; }
        public short CountryId { get; set; }
        public short Language { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PinHash { get; set; }
        public string PinVersion { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordVersion { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public DateTime LastLoginAttemptDate { get; set; }
        public DateTime LockoutEnd { get; set; }
        public short AccessFailedCount { get; set; }
        public bool PasswordEnabled { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int TwoFAProvider { get; set; }
        public short Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
