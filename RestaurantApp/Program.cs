using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello SIT1/1");
            Console.WriteLine("week 2");

            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roeast Ducg", "Beijing Chinese", 4.5 ),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6 ),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7 )
            };
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

    }
    public Restaurant(int id, string name, string type, double rating)
    {
        Id = id;
        Name = name;
        Type = type;
        Rating = rating;
    }
    public class RestaurantManager
    {
        private List<Restaurant> restaurants;
        public RestaurantManager(List<Restaurant> restaurants)
        {
            this.restaurants = restaurants;
        }
        public void DisplayRestaurants()
        {
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine($"ID: {restaurant.Id}, Name: {restaurant.Name}, Type: {restaurant.Type}, Rating: {restaurant.Rating}");
            }
        }
    }
    
}
