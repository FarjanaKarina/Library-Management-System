using LMS.DataModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataModel
{
    public class BookIssue
    {
        [Key]
        public int IssueId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal FineAmount { get; set; } = 0;
        public string? Status { get; set; } 
       
    }
}
