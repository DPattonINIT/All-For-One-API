using Microsoft.AspNetCore.Mvc;
using All_For_One_API.Services;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsService _askingQuestionsService;
        public AskingQuestionsController(AskingQuestionsService askingQuestionsService)
        {
            _askingQuestionsService = askingQuestionsService;
        }

        [HttpPost]
        [Route("AskingQuestions/{name}/{wakeUpTime}")]

        public string AskingQuestions(string name, string wakeUpTime)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(wakeUpTime))
            {
                return "Name and Wake up Time required!";
            }
            return _askingQuestionsService.GetInfo(name, wakeUpTime);
        }


    }
}