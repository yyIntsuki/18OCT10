using _18OCT10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18OCT10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse()
        {
            return View(cars);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User ur)
        {
            if (ModelState.IsValid)
            {
                return View("Result", ur);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(User r)
        {
            if (ModelState.IsValid)
            {
                return View("Result", r);
            }
            else
            {
                return View();
            }
        }

        // Fake data, acts as database data.
        private List<Car> cars;
        private List<User> customers;

        // Constructor, code that automatically initiate on new
        public HomeController()
        {
            cars = new List<Car>();
            cars.Add(new Car() { Make = "Nissan", Model = "Leaf", RegistrationNum = "LEAF01"});
            cars.Add(new Car() { Make = "Jaguar", Model = "I-Pace", RegistrationNum = "JAGU01" });
            cars.Add(new Car() { Make = "Tesla", Model = "S", RegistrationNum = "TESL01"});
            cars.Add(new Car() { Make = "Tesla", Model = "X", RegistrationNum = "TESL02" });
            cars.Add(new Car() { Make = "Tesla", Model = "3", RegistrationNum = "TESL03" });
            cars.Add(new Car() { Make = "Tesla", Model = "Roadster", RegistrationNum = "TESL04" });

            customers = new List<User>();
            customers.Add(new User() { name = "Intsuki" });
        }

        public PartialViewResult Cars()
        {
            return PartialView("_Cars", cars);
        }

        public ViewResult Details(string RegistrationNum)
        {
            return View("carDetails", cars.First(x => x.RegistrationNum == RegistrationNum));
        }

        public PartialViewResult Users()
        {
            return PartialView("_Customers", customers);
        }
    }
}