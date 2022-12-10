using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Range(0.00, 100_000_000.00)]
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
