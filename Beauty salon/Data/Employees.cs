using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_salon.Data
{
    internal class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Position { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }
    }
}
