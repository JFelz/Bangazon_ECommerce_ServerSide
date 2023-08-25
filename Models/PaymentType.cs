using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
