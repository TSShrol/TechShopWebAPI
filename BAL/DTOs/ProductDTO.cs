using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
       public string Title { get; set; }
        public string Description { get; set; }
        //Range 
         public decimal Price { get; set; }
        //URL
        public string? ImagePath { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
