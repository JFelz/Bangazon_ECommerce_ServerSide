using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int SellerId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string imageUrl { get; set; }
        [Required]
        public decimal price { get; set; }
        public bool isSoldOut { get; set; }
    }
}
