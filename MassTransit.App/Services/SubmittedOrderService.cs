using MassTransit.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Services
{
    internal class SubmittedOrderService
    {
        private readonly ConsoleNotificationService _consoleNotificationService;

        public SubmittedOrderService(ConsoleNotificationService consoleNotificationService)
        {
            _consoleNotificationService = consoleNotificationService;
        }

        public async Task Process(OrderSubmitted order)
        {
            await Task.Delay(1000);

            _consoleNotificationService.Notify(order);
        }
    }
}
