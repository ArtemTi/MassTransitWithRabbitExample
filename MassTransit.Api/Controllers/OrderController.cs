using MassTransit.App.Models;
using MassTransit.App.Producers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MassTransit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderProducer _orderProducer;

        public OrderController(OrderProducer orderProducer)
        {
            _orderProducer = orderProducer;
        }

        [HttpPost]
        public async Task<IActionResult> Order(Order order) 
        {
            await _orderProducer.PostOrder(order);

            return Ok();
        }
    }
}
