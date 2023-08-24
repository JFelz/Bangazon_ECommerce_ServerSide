namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int SellerId { get; set; }
        public Seller seller { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public DateTime DatePurchased { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus status { get; set; }
        public DateTime StatusUpdateDate { get; set; }
    }
}
