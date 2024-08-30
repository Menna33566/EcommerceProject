using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        // Quantity of the product ordered
        [Required]
        public int Quantity { get; set; }

        // Status of the order
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        // Foreign key to User
        public int UserId { get; set; }

        // Navigation property for the user who placed the order
        [ForeignKey("UserId")]
        public User User { get; set; }

        // Foreign key to Product
        public int ProductId { get; set; }

        // Navigation property for the product in the order
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
