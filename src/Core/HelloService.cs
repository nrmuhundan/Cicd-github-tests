namespace Core;

public interface IHelloService
{
    string GetGreeting();
}

public class HelloService : IHelloService
{
    public string GetGreeting() => "Hello world!!";
}
