using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Models;

namespace AllForOneAPI.Services
{
    public class RestaurantPickerServices
    {
        public List<ResaurantPickerModel> RestaurantPickerRestaurants =
        [
            new ResaurantPickerModel { Type = "Fast Food", Restaurant = ["McDonalds", "Wendy's", "In-n-out", "Carl's Jr", "Raising Cain's", "Chick-fil-a", "Chipotle", "Jack in the Box", "Popeyes", "Sonic"] },

            new ResaurantPickerModel { Type = "Pizza", Restaurant = ["Dominos", "Mountain Mike's", "Eddie's Pizza", "Round Table", "Prime Pizza CA", "Pizza Castle", "Sam's Pizza & More", "Fresh Slice Pizza", "Pieology", "Blaze Pizza"] },

            new ResaurantPickerModel { Type = "Food Truck", Restaurant =["Los Compadres", "Lonchera Hidalgo", "El Mayita", "Tacos Guadalajara", "Bienvenidos T. EL Grullense", "Nikki's Create-A-Bowl", "El Comal", "A Little Bit of Everything", "Braz Burger", "209 Charles Place"] }
        ];

        public string RestaurantPicker(string Type)
        {
            Random rng = new Random();
            int randomRes = rng.Next(11);
            string catagory = Type;

            switch (catagory.ToLower())
            {
                case "fast food":
                    return $"You have chosen the category: Fast Food\nYour restaurant is {RestaurantPickerRestaurants[0].Restaurant![randomRes]}";

                case "pizza":
                    return $"You have chosen the category: Pizza\nYour restaurant is {RestaurantPickerRestaurants[1].Restaurant![randomRes]}";

                case "food truck":
                    return $"You have chosen the category: Food Trucks\nYour restaurant is {RestaurantPickerRestaurants[2].Restaurant![randomRes]}";

                default:
                    return "Sorry what is not a valid input\nPlease make sure your input is one of the three catagories: fast food, pizza, or food trucks.\nPlease make sure the spelling is correct.";
            }
        }
    }
}