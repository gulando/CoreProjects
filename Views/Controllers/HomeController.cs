using System;
using Microsoft.AspNetCore.Mvc;


namespace Views.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    ViewBag.Message = "Hello, World";
        //    ViewBag.Time = DateTime.Now.ToString("HH:mm:ss");
        //    return View("DebugData");
        //}

        // public ViewResult Index() => View(new string[] { "Apple", "Orange", "Pear" });

        public ViewResult Index() => View("MyView", new string[] { "Apple", "Orange", "Pear" });

        public ViewResult List() => View();


    }
}