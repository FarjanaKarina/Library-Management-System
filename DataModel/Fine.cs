using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataModel
{
    public class Fine
    {
        [Key]
        public int FineId { get; set; }

        public int MemberId { get; set; }

        // If you have a table for Book Issues, link it too
        public int? IssueId { get; set; } // Optional — related to issued book

        public decimal FineAmount { get; set; }

        public string PaymentStatus { get; set; } = "Unpaid"; // Paid / Unpaid

        public DateTime FineDate { get; set; } = DateTime.Now;

        public DateTime? PaymentDate { get; set; }

    }
}
