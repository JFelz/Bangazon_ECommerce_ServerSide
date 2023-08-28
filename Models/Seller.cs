using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Seller
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }
        public string imageUrl { get; set; }

        public int PaymentType_Id { get; set; }
    }
}
