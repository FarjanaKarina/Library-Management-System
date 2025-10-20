namespace LMS.Data_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required, StringLength(100)]
        public string MemberName { get; set; }

        [Required, StringLength(50)]
        public string MemberType { get; set; } // e.g., Student, Teacher, Guest

        [StringLength(150)]
        [EmailAddress]
        public string ContactInfo { get; set; }

        [Required, StringLength(20)]
        public string Status { get; set; } = "Active"; // Active / Inactive

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Navigation property — A member can have multiple fines
        public ICollection<Fine> Fines { get; set; }
    }

