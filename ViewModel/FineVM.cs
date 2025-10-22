namespace LMS.ViewModel
{
    public class FineVM
    {
        public Guid FineId { get; set; }

        public Guid MemberId { get; set; }
        public Guid BookIssueId { get; set; } // Optional — related to issued book

        public decimal FineAmount { get; set; }

        public string PaymentStatus { get; set; } = "Unpaid"; // Paid / Unpaid

        public DateTime FineDate { get; set; } = DateTime.Now;

        public DateTime? PaymentDate { get; set; }

        public MemberVM? MemberVM { get; set; }
        public BookVM? BookVM { get; set; } 
}
}
