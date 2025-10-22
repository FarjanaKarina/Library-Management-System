using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DataModel
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }
        [StringLength(25)]
        public string? Title { get; set; }
        [StringLength(25)]
        public string Author { get; set; }= string.Empty;
        [StringLength(25)]
        public string? Publisher { get; set; }
        [StringLength(25)]
        public string? Category { get; set; }
        public DateTime PurchaseDate{ get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [StringLength(25)]
        public string? Status { get; set; }

    }
}
