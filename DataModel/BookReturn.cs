using System.ComponentModel.DataAnnotations;

namespace LMS.DataModel
{
    public class BookReturn
    {
        [Key]
        public Guid ReturnId { get; set; }
        public Guid IssueId { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal FineAmount { get; set; }
        public string? Remarks { get; set; }
    }
}
