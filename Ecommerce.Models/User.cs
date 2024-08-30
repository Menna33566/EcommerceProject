using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int UserTypeId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(UserTypeId))]
        public UserType UserType { get; set; }

        //Nourhan Added
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
