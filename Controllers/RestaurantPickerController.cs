using Microsoft.AspNetCore.Mvc;
using All_For_One_API.Services;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {

        private readonly RestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet("{category}")]
        public string GetRestaurant(string category)
        {
            var restaurant = _restaurantPickerService.PickRandomRestaurant(category);
            return restaurant;
        }
    }
}