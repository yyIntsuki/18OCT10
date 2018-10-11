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

        public ActionResult Rent()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(UserRegistration ur)
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
        public ActionResult Result(UserRegistration r)
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
    }
}