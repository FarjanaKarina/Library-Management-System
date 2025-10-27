using System.ComponentModel.DataAnnotations;

namespace LMS.DataModel
{
    public class BookIssue
    {
        [Key]
        public Guid IssueId { get; set; }
        public Guid MemberId { get; set; }
        public Guid BookId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; } // nullable
        public decimal FineAmount { get; set; }
    }
}
