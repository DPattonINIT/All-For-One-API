using Microsoft.AspNetCore.Mvc;
using All_For_One_API.Services;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItWordController : ControllerBase
    {
        private readonly ReverseItWordService _reverseItWordService;
        public ReverseItWordController(ReverseItWordService reverseItWordService)
        {
            _reverseItWordService = reverseItWordService;
        }
        [HttpGet("{input}")]
        public string ReverseWord(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return "Input cannot be empty.";
            }
            var reversed = _reverseItWordService.ReverseWord(input);
            return $"You entered {input}, reversed is {reversed}";

        }
    }
}