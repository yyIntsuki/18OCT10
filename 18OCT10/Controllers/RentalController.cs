using _18OCT10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18OCT10.Controllers
{
    public class RentalController : Controller
    {
        // Fake data, acts as database data.
        private List<Car> cars;
        private List<UserRegistration> customers;

        //Constructor
        public RentalController()
        {
            cars = new List<Car>();
            cars.Add(new Car() { RegistrationNum = "ABC123" });
            cars.Add(new Car() { RegistrationNum = "DFG456" });

            customers = new List<UserRegistration>();
            customers.Add(new UserRegistration() { name = "Intsuki" });
        }
        // GET: Rental
        public ActionResult Index()
        {
            return View();
        }
    }
}