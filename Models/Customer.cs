namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string imageUrl { get; set; }
        public int PaymentType_Id { get; set; }
    }
}
