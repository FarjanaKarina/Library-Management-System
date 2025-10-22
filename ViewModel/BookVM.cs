using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModel
{
    public class BookVM
    {
        public Guid BookId { get; set; }
        [StringLength(25)]
        public string? Title { get; set; }
        [StringLength(25)]
        public string Author { get; set; } = string.Empty;
        [StringLength(25)]
        public string? Publisher { get; set; }
        [StringLength(25)]
        public string? Category { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [StringLength(25)]
        public string? Status { get; set; }
    }
}
