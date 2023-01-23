using MassTransit.App.Models;
using MassTransit.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Consumers
{
    internal class SubmittedOrderConsumer : IConsumer<OrderSubmitted>
    {
        private readonly SubmittedOrderService _submittedOrderService;

        public SubmittedOrderConsumer(SubmittedOrderService submittedOrderService)
        {
            _submittedOrderService = submittedOrderService;
        }

        public async Task Consume(ConsumeContext<OrderSubmitted> context)
        {
            await _submittedOrderService.Process(context.Message);
        }
    }
}
