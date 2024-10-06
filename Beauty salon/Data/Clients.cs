using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_salon.Data
{
    internal class Clients
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string FullName { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}
