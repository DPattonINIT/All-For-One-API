using All_For_One_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersService _addingTwoNumbersService;

        public AddingTwoNumbersController(AddingTwoNumbersService addingTwoNumbersService)
        {
            _addingTwoNumbersService = addingTwoNumbersService;
        }

        [HttpGet]
        [Route("FetchUserNumbers/{userNum1}/{userNum2}")]
        public string AddingNumbers(int userNum1, int userNum2)
        {
            int results = userNum1 + userNum2;

            return $"The sum of {userNum1} and {userNum2} is {results}";
        }
    }
}