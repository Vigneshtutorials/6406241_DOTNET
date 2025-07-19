using Confluent.Kafka;

class Program
{
    static async Task Main()
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Kafka Producer Started. Type messages to send:");

        while (true)
        {
            Console.Write("You: ");
            string? input = Console.ReadLine();
            if (input == "exit") break;

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });
        }
    }
}
