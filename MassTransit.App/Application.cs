using MassTransit.App.Consumers;
using MassTransit.App.Models;
using MassTransit.App.Producers;
using MassTransit.App.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App
{
    public static class Application
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration config)
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumer<OrderConsumer>();
                x.AddConsumer<SubmittedOrderConsumer>();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("localhost", "/", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

            services.AddTransient<ConsoleNotificationService>();
            services.AddTransient<SubmittedOrderService>();
            services.AddTransient<OrderProducer>();
        }
    }
}
