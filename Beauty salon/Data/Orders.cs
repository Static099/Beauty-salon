using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_salon.Data
{
    internal class Orders
    {
        public int OrderId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Clients Client { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        public int ServiceId { get; set; }
        public Services Service { get; set; }

        public DateTime OrderDateTime { get; set; }

        public OrderStatus Status { get; set; }
    }
    public enum OrderStatus
    {
        [Display(Name = "Выполнен")]
        Completed,

        [Display(Name = "В работе")]
        InProgress
    }
}

