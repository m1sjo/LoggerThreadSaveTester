using LoggerThreadSaveTester;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
              {
                  services.AddTransient<SomeLoggingClass>();
                  services.AddTransient<OtherLoggingClass>();
              }).Build();

Stack<Task> list = new ();

for (int i = 0; i < 10; i++)
{
    list.Push(host.Services.GetRequiredService<SomeLoggingClass>().LogOtherStuffFiveTimes());
    list.Push(host.Services.GetRequiredService<OtherLoggingClass>().LogOtherStuffFiveTimes());
}

do
{
    await list.Pop();
} while (list.Any());
