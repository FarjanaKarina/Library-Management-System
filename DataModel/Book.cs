using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataModel
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string Author { get; set; }= string.Empty;
        public string? Publisher { get; set; }
        public string? Category { get; set; }
        public DateTime PurchaseDate{ get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Status { get; set; }

    }
}
