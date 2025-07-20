using Confluent.Kafka;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var sender = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Type a message and press Enter to send. Type 'exit' to quit.");

        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;
            if (input.ToLower() == "exit") break;

            try
            {
                var result = await sender.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });
                Console.WriteLine($"Sent: {result.Value}");
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
            }
        }
    }
}
