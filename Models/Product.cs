﻿using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int SellerId { get; set; }
        
        public int CategoryId { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string imageUrl { get; set; }
        
        public decimal price { get; set; }
        public bool isSoldOut { get; set; }
    }
}
