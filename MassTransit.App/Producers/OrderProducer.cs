using MassTransit.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Producers
{
    public class OrderProducer
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public OrderProducer(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task PostOrder(Order order)
        {
            await _publishEndpoint.Publish(order);
        }
    }
}
