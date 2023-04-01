using MassTransit;
using ModelLibrary;

internal class OrderConsumer : IConsumer<Order>
{
    private readonly ILogger<OrderConsumer> logger;

    public OrderConsumer(ILogger<OrderConsumer> logger)
    {
        this.logger = logger;
    }
    public async Task Consume(ConsumeContext<Order> context)
    {
        await Console.Out.WriteLineAsync(context.Message.Name);
        logger.LogInformation($"Got new Message{context.Message.Name})");
    }
}