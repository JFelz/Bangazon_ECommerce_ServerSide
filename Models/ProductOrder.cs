using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
