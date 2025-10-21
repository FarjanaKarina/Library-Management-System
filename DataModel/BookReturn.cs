using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataModel
{
    public class BookReturn
    {
        [Key]
        public int ReturnId { get; set; }
        public int IssueId { get; set; }
        public DateTime ReturnDate { get; set; } = DateTime.Now;
        public decimal FineAmount { get; set; } = 0;
        public string? Remarks { get; set; }
  
    }
}
