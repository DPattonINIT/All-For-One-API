using Microsoft.AspNetCore.Mvc;
using All_For_One_API.Services;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumberController : ControllerBase
    {
        private readonly ReverseItNumberService _reverseItNumberService;
        public ReverseItNumberController(ReverseItNumberService reverseItNumberService)
        {
            _reverseItNumberService = reverseItNumberService;
        }

        [HttpGet("{number}")]
        public string ReverseNumber(string number)
        {

            if (!int.TryParse(number, out int parsedNumber))
            {

                return "Invalid input. Please enter a valid number.";
            }
            return _reverseItNumberService.ReverseNumber(number);
        }
    }
}