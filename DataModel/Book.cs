using System.ComponentModel.DataAnnotations;

namespace LMS.DataModel
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Category { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Status { get; set; } // Available, Issued, Lost, Damaged
    }

}
