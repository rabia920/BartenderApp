using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApp.Models;


namespace BartenderApp.Controllers
{

    public class HomeController : Controller
    {
        DrinkContext drinkContext;
        public HomeController(DrinkContext DrinkDatabase)
        {
            drinkContext = DrinkDatabase;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult ShowDrinks()
        {

            DrinksModel Drink = new DrinksModel
            {
               
            };
           

            return View("ShowDrinks", Drink);  //Drink is the view model which is created within methods, or the model class.
            //Drink was created as a model bc it is not primitive like a string. if it was just a string
            //you'd do it in a method just like java c:
        }


        [HttpPost]
        public IActionResult OrderDrinks(string DrinkName)
        {

            Order CustomerOrder = new Order {

                DrinkName = DrinkName, //the left hand side DrinkName has to match the name value of the form
                orderTime = DateTime.Now


            };

            drinkContext.Add(CustomerOrder);
            drinkContext.SaveChanges();



            return View();
        }

        [HttpGet]
        public IActionResult GetQueue(int Id)
        {
            IEnumerable<Order> orders= drinkContext.Drinks;

            return View("GetQueue", orders);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {

            drinkContext.Remove(drinkContext.Drinks.Find(Id));
            drinkContext.SaveChanges();
            

            return View("GetQueue", drinkContext.Drinks);
        }

        public IActionResult BarFoodMenu()
        {
            BarFood Food = new BarFood
            {   
            
            };

            return View("BarFoodMenu", Food);
        }


        public IActionResult GetDesserts()
        {

            string[] dessertyum = Desserts.DessertsArray;


            return View("Desserts", dessertyum);
        }

        [HttpGet]
        public IActionResult PostDessert(string dessertName)
        {
            BarDesserts delicious = new BarDesserts
            {
               DessertName = dessertName
            };

            //drinkContext.Add(delicious);
            //drinkContext.SaveChanges();

            return View("PostDesserts", delicious);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
