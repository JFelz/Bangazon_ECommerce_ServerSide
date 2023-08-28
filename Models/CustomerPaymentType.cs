using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class CustomerPaymentType
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public int PaymentType_Id { get; set; }
    }
}
