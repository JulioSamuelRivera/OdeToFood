using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { RestaurantId = 1, Name = "Sage French Cafe", Cuisine = CuisineType.French },
                new Restaurant { RestaurantId = 2, Name = "Indian Curry and Sweets", Cuisine = CuisineType.Indian },
                new Restaurant { RestaurantId = 3, Name = "Goodfellas Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { RestaurantId = 4, Name = "Q'Rico!!! Latin Fusion Food", Cuisine = CuisineType.Latin}
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.RestaurantId = restaurants.Max(r => r.RestaurantId) + 1;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.RestaurantId == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
