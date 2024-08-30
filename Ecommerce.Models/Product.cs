using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string ImageURL { get; set; }
        public int Quantity { get; set; }

        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }
        /////
        /// sadasdasdasd
        ///
    }
}
