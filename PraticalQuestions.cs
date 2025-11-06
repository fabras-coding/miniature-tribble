// Review the following C# async method and identify any issues that could cause deadlocks or performance bottlenecks. Suggest improvements:

using System.Threading.Tasks;

public async Task<string> GetData()
{
    var data = await GetDataAsync();
    return data;
}

public async Task<string> GetDataAsync()
{
    await Task.Delay(1000);
    return "Hello World";
}

// Given the following Kafka consumer code snippet, identify any potential issues that could lead to message loss or processing delays and suggest improvements:

var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("my-topic");
while (true)
{
    var consumeResult = consumer.Consume();

    if (ProcessMessage(consumeResult.Message.Value))
    {
        consumer.Commit(consumeResult);
    }
}