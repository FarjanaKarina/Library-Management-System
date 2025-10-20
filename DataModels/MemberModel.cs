using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Member name is required")]
        [StringLength(100)]
        public string MemberName { get; set; }

        [Required(ErrorMessage = "Member type is required")]
        [StringLength(50)]
        public string MemberType { get; set; } // e.g., Student, Teacher, Public

        [StringLength(150)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string ContactInfo { get; set; } // can store email or phone

        [Required]
        public string Status { get; set; } = "Active"; // Active / Inactive

        [DataType(DataType.Date)]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
