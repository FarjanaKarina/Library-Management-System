using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModel
{
    public class BookIssueVM
    {
        public Guid BookIssueId { get; set; }
        public Guid MemberId { get; set; }
        public Guid BookId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal FineAmount { get; set; } = 0;
        [StringLength(25)]
        public string? Status { get; set; }
    }
}
