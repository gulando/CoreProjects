using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Filters.Controllers
{
    //[RequireHttps]
    //[HttpsOnly]
    //[Profile]
    //[ViewResultDetails]
    //[RangeException]

    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[ServiceFilter(typeof(TimeFilter))]

    //[TypeFilter(typeof(TimeFilter))]

    [Message("This is the Controller-Scoped Filter")]
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    if (!Request.IsHttps)
        //    {
        //        return new StatusCodeResult(StatusCodes.Status403Forbidden);
        //    }
        //    else
        //    {
        //        return View("Message", "This is the Index action on the Home controller");
        //    }
        //}

        //[RequireHttps]

        [Message("This is the First Action-Scoped Filter")]
        [Message("This is the Second Action-Scoped Filter")]
        public ViewResult Index() => View("Message", "This is the Index action on the Home controller");

        public ViewResult SecondAction() => View("Message", "This is the SecondAction action on the Home controller");

        public ViewResult GenerateException(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            else if (id > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            else
            {
                return View("Message", $"The value is {id}");
            }

        }

    }
}