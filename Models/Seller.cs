using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        public string imageUrl { get; set; }
        [Required]
        public int PaymentType_Id { get; set; }
    }
}
