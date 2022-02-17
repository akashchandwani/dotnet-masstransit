using System;
using System.Threading.Tasks;
using MassTransit;

namespace OrderService
{
    internal class OrderConsumer : IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Name);
        }
    }
}