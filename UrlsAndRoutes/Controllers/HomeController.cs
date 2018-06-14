﻿using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;


namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Result",
        new Result
        {
            Controller = nameof(HomeController),
            Action = nameof(Index)
        });

        public ViewResult CustomVariable()
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable),
            };
            r.Data["Id"] = RouteData.Values["id"];
            r.Data["Url"] = Url.Action("CustomVariable", "Home", new { id = 100 });
            return View("Result", r);
        }

        public ViewResult CustomVariable2(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable2),
            };
            r.Data["Id"] = id ?? "<no value>";
            return View("Result", r);
        }

    }
}