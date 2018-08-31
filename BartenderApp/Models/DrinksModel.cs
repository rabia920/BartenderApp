using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class DrinksModel
    {
    public string Blowjob { get; set; }

    public string VeganBailey { get; set; }

    public string[] Drinks = new string[] { "Sweet Drink", "Sour Drink", "Hard Drink", "Soft Drink", "Beer", "Wine", "Vodka", "Whiskey" };

    }


    public class Order

    {
        public int OrderId { get; set; }

        public DateTime orderTime { get; set; }

        public string DrinkName { get; set; }

    }

    public class BarFood
    {
        public int OrderFoodId { get; set; }
        public DateTime FoodOrderTime { get; set; }
        public string[] Foods = new string[] { "Mac and Cheese balls", "Fried green tomatoes", "banana chips", "yucca fries", "Vg doubledown" };
    }

    public class BarDesserts
    {
         
        public int BarDessertsId { get; set; }
        public DateTime DessertOrderTime { get; set; }
        
        public string DessertName { get; set; }
    }

    public static class Desserts
    {
        public static string[] DessertsArray = new string[] { "Ice-cream", "Cookies", "Brownies" };
    }
}

