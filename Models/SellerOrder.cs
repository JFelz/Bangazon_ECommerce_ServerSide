﻿using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class SellerOrder
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int SellerId { get; set; }
    }
}
