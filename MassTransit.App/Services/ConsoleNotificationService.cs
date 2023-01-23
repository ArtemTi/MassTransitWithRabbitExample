using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.App.Services
{
    public class ConsoleNotificationService
    {
        public void Notify<T>(T message) 
        {
            if (message is null)
            {
                Console.WriteLine("Empty message");
                return;
            }

            Console.WriteLine(message.ToString());
        }
    }
}
