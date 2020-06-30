using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()//como el metodo se llama Index llamara al view index
        {
            //ejemplo usando model
            var obj = new { Id = 1, Name = "Samuel" };
            return View(obj);
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
