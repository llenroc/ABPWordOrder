using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using WorkOrder.Users;

namespace WorkOrder.WorkOrder
{
    class WorkOrder : Entity<long>
    {
        public string No { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public User SubmitUser { get; set; }

        public User UndertakeUser { get; set; }

        public DateTime SubmitTime { get; set; }

        public DateTime CompleteTime { get; set; }

        public OrderStatus Status { get; set; }
    }
}
