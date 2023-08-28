using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class SellerPaymentType
    {
        public int Id { get; set; }
        [Required]
        public int SellerId { get; set; }

        public int PaymentType_Id { get; set; }
    }
}
