using System.ComponentModel.DataAnnotations;

namespace Bangazon_ECommerce_ServerSide.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string uid { get; set; }
        public string displayName { get; set; }
        public string email { get; set; }
        public string photoURL { get; set; }
    }
}
