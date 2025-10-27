using System.ComponentModel.DataAnnotations;

namespace LMS.DataModel
    {
        public class Staff
        {
            [Key]
            public Guid StaffId { get; set; } // Auto increment (PK)
            public string? FullName { get; set; }
            public string? Role { get; set; } // e.g. "Admin", "Librarian", "Assistant"
            public string? Username { get; set; }
            public string? Password { get; set; } // You’ll store plain text first, later can add hashing
            public string? ContactNumber { get; set; }
            public string? Email { get; set; }
            public DateTime JoinDate { get; set; }
            public string? Status { get; set; } // "Active" or "Inactive"
        }
    }

