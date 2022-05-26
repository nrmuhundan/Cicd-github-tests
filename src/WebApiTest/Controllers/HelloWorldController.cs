using Core;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers;
[ApiController]
[Route("helloworld")]
public class HelloWorldController : ControllerBase
{
    private readonly IHelloService _helloService;

    public HelloWorldController(IHelloService helloService)
    {
        _helloService = helloService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var value = _helloService.GetGreeting() + "!!";
        return Ok(value);
    }
}
