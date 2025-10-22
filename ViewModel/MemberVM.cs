using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModel
{
    public class MemberVM
    {
        public Guid MemberId { get; set; }
        [StringLength(25)]
        public string? MemberName { get; set; }
        [StringLength(25)]
        public string? MemberType { get; set; } // e.g., Student, Teacher, Guest
        [StringLength(25)]
        public string? ContactInfo { get; set; }
        [StringLength(25)]
        public string Status { get; set; } = "Active"; // Active / Inactive
        public DateTime ExpiryDate { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public object MembershipDate { get; internal set; }
        public object PhoneNumber { get; internal set; }
        public object Email { get; internal set; }
        public object Name { get; internal set; }
    }
}
