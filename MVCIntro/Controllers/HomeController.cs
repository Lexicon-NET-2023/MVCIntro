using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index(string name = "Nisse")
        {
            TempData["Name"] = name;
            ViewBag.Name = name;


            // var model = new List<string>() { "Hej", "Då", "Igen", "sfsf"};
            var model = new Employee { Name = "Kalle", Salary = 10000 };

            return View("Index4", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetValues(string name, int salary)
        {
            return View("Index2");
        } 
        
        public IActionResult GetValues2(Employee employee)
        {
            return View("Index3");
        }

    }
}