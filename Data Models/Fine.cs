using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Data_Models
{
    public class Fine
    {
        [Key]
        public int FineId { get; set; }

        [Required]
        [ForeignKey("Member")]
        public int MemberId { get; set; }

        // If you have a table for Book Issues, link it too
        public int? IssueId { get; set; } // Optional — related to issued book

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal FineAmount { get; set; }

        [Required, StringLength(20)]
        public string PaymentStatus { get; set; } = "Unpaid"; // Paid / Unpaid

        [DataType(DataType.Date)]
        public DateTime FineDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? PaymentDate { get; set; }

        // Navigation properties
        public Member Member { get; set; }
    }
}
