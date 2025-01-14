using All_For_One_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly SayHelloService _sayHelloService;

        public HelloWorldController(SayHelloService sayHelloService)
        {
            _sayHelloService = sayHelloService;
        }

        [HttpPost]
        [Route("AddName/{name}")]

        public string AddName(string name)
        {
            return _sayHelloService.AddName(name);
        }
    }
}