using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class CustomerProduct
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
