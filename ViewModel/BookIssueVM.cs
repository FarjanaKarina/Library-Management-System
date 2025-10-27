using System;

namespace LMS.ViewModel
{
    public class BookIssueVM
    {
        public Guid IssueId { get; set; }
        public Guid BookId { get; set; }
        public Guid MemberId { get; set; }

        public string? BookTitle { get; set; }
        public string? MemberName { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? FineAmount { get; set; }
    }
}
