using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Models
{
    public class OrderSubmitted
    {
        public OrderSubmitted(Guid orderId)
        {
            OrderId = orderId;
            SubmittedDate = DateTime.Now;
        }

        public Guid OrderId { get; }

        public DateTime SubmittedDate { get; }

        public override string ToString()
        {
            return $"OrderId = {OrderId}, SubmittedDate = {SubmittedDate}";
        }
    }
}
