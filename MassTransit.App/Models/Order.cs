using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Models
{
    public class Order
    {
        public Order(string productName)
        {
            OrderId = Guid.NewGuid();
            ProductName = productName;
        }

        public Guid OrderId { get; }

        public string ProductName { get; }

        public override string ToString()
        {
            return $"OrderId = {OrderId}, ProductName = {ProductName}";
        }
    }
}
