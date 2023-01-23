using MassTransit.App.Models;
using MassTransit.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Consumers
{
    public class OrderConsumer : IConsumer<Order>
    {
        private readonly ConsoleNotificationService _consoleNotificationService;

        public OrderConsumer(ConsoleNotificationService consoleNotificationService)
        {
            _consoleNotificationService = consoleNotificationService;
        }

        public async Task Consume(ConsumeContext<Order> context)
        {
            _consoleNotificationService.Notify(context.Message);

            await context.Publish(new OrderSubmitted(context.Message.OrderId));
        }
    }
}
