using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index() => View(DateTime.Now);

        public ViewResult Index1()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }
        
        public ViewResult Result0() => View((object)"Hello World");

        public ViewResult Result1() => View("Hello World");


        public JsonResult Index2() => Json(new[] { "Alice", "Bob", "Joe" });

        public ContentResult Index3() => Content("[\"Alice\",\"Bob\",\"Joe\"]", "application/json");

        public ObjectResult Index4() => Ok(new string[] { "Alice", "Bob", "Joe" });

        public VirtualFileResult Index5() => File("/lib/bootstrap/dist/css/bootstrap.css", "text/css");

        public StatusCodeResult Index6() => StatusCode(StatusCodes.Status404NotFound);

        public StatusCodeResult Index7() => NotFound();

        public ActionResult Index8() => new EmptyResult();


        public RedirectResult Redirect0() => Redirect("/Example/Index");

        public RedirectResult Redirect1() => RedirectPermanent("/Example/Index");

        public RedirectToRouteResult Redirect2() => RedirectToRoute(new
        {
            controller = "Example",
            action = "Index",
            ID = "MyID"
        });

        public RedirectToActionResult Redirect3() => RedirectToAction(nameof(Index));

        public RedirectToActionResult Redirect4() => RedirectToAction(nameof(HomeController), nameof(HomeController.Index));

    }
}