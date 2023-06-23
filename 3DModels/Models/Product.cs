using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3DModels.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
