using Core;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddScoped<IHelloService, HelloService>()
    .BuildServiceProvider();

var helloService = serviceProvider.GetService<IHelloService>();


Console.WriteLine(helloService.GetGreeting());
