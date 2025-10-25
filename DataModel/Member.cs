using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LMS.DataModel
{
    public class Member
    {
        [Key]
        public Guid MemberId { get; set; }
        [StringLength(25)]
        public string? MemberName { get; set; }
        [StringLength(25)]
        public string? MemberType { get; set; } // e.g., Student, Teacher, Guest
        [StringLength(25)]
        public string? ContactInfo { get; set; }
        public string? Address { get; set; }
        [StringLength(25)]
        public string Status { get; set; } = "Active"; // Active / Inactive
        public DateTime ExpiryDate { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public object Name { get; internal set; }
        public object Email { get; internal set; }
        public object PhoneNumber { get; internal set; }
        public object MembershipDate { get; internal set; }
    }
}
