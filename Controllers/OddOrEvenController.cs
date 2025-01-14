using Microsoft.AspNetCore.Mvc;
using All_For_One_API.Services;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEvenService;

        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _oddOrEvenService = oddOrEvenService;
        }
        [HttpGet("{number}")]
        public string CheckOddOrEven(int number)
        {
            var result = _oddOrEvenService.CheckOddOrEven(number);
            return result;
        }
    }
}