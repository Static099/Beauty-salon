using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_salon.Data
{
    internal class Services
    {
        [Key]
        public int ServiceId { get; set; }

        // Наименование услуги
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        // Описание услуги
        public string Description { get; set; }

        // Внешний ключ для сотрудника
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        // Стоимость услуги
        [Column(TypeName = "decimal(10)")]
        public decimal Price { get; set; }
    }
}

