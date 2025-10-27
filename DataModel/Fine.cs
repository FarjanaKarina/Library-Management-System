using System.ComponentModel.DataAnnotations;

namespace LMS.DataModel
{
    public class Fine
    {
        [Key]
        public Guid FineId { get; set; }
        public Guid MemberId { get; set; }
        public Guid IssueId { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime FineDate { get; set; }
        public string? PaymentStatus { get; set; } // Paid / Unpaid
    }

}
