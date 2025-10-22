using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModel
{
    public class BookReturnVM
    {
        public Guid BookReturnId { get; set; }
        public Guid BookIssueId { get; set; }
        public DateTime ReturnDate { get; set; } = DateTime.Now;
        public decimal FineAmount { get; set; } = 0;
        [StringLength(25)]
        public string? Remarks { get; set; }
    }
}
