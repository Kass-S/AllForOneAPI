using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerService;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerService){
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("Pick/{fastFoodPizzaFoodTruck}")]

        public string RestaurantPicker(string fastFoodPizzaFoodTruck){
            return _restaurantPickerService.RestaurantPicker(fastFoodPizzaFoodTruck);
        }
    }
}