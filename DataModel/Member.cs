using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LMS.DataModel
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string? MemberName { get; set; }
        public string? MemberType { get; set; } // e.g., Student, Teacher, Guest
        public string? ContactInfo { get; set; }
        public string Status { get; set; } = "Active"; // Active / Inactive
        public DateTime ExpiryDate { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

    }
}
