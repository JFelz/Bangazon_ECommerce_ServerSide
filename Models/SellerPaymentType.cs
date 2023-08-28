using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class SellerPaymentType
    {
        public int SellerId { get; set; }

        public int PaymentType_Id { get; set; }
    }
}
