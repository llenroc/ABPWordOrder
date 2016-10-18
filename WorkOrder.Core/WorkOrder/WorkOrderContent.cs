using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using WorkOrder.Users;

namespace WorkOrder.WorkOrder
{
    class WorkOrderContent : Entity<long>
    {
        public string Content { get; set; }

        public User ContentBy { get; set; }

        public DateTime ReplyTime { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }

        public long WorkOrderId { get; set; }
    }
}
