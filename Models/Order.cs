using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public Customer customer { get; set; }
        [Required]
        public int SellerId { get; set; }
        [Required]
        public Seller seller { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public Product product { get; set; }
        [Required]
        public DateTime DatePurchased { get; set; }
        [Required]
        public int OrderStatusId { get; set; }
        [Required]
        public OrderStatus status { get; set; }
        [Required]
        public DateTime StatusUpdateDate { get; set; }
    }
}
