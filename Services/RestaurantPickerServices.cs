using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class RestaurantPickerServices
    {
        public string RestaurantPicker(string fastFoodPizzaFoodTruck)
        {
            string[] fastFoodArray = { "McDonalds", "Wendy's", "In-n-out", "Carl's Jr", "Raising Cain's", "Chick-fil-a", "Chipotle", "Jack in the Box", "Popeyes", "Sonic" };
            string[] pizzaArray = { "Dominos", "Mountain Mike's", "Eddie's Pizza", "Round Table", "Prime Pizza CA", "Pizza Castle", "Sam's Pizza & More", "Fresh Slice Pizza", "Pieology", "Blaze Pizza" };
            string[] foodTruckArray = { "Los Compadres", "Lonchera Hidalgo", "El Mayita", "Tacos Guadalajara", "Bienvenidos T. EL Grullense", "Nikki's Create-A-Bowl", "El Comal", "A Little Bit of Everything", "Braz Burger", "209 Charles Place" };

            Random rng = new Random();
            int randomRes = rng.Next(10);
            string catagory = fastFoodPizzaFoodTruck;

            switch (catagory.ToLower())
            {
                case "fast food":
                    return $"You have chosen the category: Fast Food\nYour restaurant is {fastFoodArray[randomRes]}";

                case "pizza":
                    return $"You have chosen the category: Pizza\nYour restaurant is {pizzaArray[randomRes]}";

                case "food truck":
                    return $"You have chosen the category: Food Trucks\nYour restaurant is {foodTruckArray[randomRes]}";

                default:
                    return "Sorry what is not a valid input\nPlease make sure your input is one of the three catagories: fast food, pizza, or food trucks.\nPlease make sure the spelling is correct.";
            }
        }
    }
}