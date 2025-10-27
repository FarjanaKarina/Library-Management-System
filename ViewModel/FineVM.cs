using System;

namespace LMS.ViewModel
{
    public class FineVM
    {
        public Guid FineId { get; set; }
        public string? MemberName { get; set; }
        public string? BookTitle { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime FineDate { get; set; }
        public string? PaymentStatus { get; set; } // Paid / Unpaid
    }
}
