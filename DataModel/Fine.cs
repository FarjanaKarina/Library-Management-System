using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataModel
{
    public class Fine
    {
        [Key]
        public Guid FineId { get; set; }

        public Guid MemberId { get; set; }
        public Guid BookIssueId { get; set; } // Optional — related to issued book

        public decimal FineAmount { get; set; }

        public string PaymentStatus { get; set; } = "Unpaid"; // Paid / Unpaid

        public DateTime FineDate { get; set; } = DateTime.Now;

        public DateTime? PaymentDate { get; set; }
        public object MemberName { get; internal set; }
        public object Amount { get; internal set; }
        public object Reason { get; internal set; }
        public object DateIssued { get; internal set; }
    }
}
