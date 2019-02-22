using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //public ViewResult Index() => View(DateTime.Now);

        //public ViewResult Index()
        //{
        //    ViewBag.Message = "Hello";
        //    ViewBag.Date = DateTime.Now;
        //    return View();
        //}

        //public JsonResult Index() => Json(new[] { "Alice", "Bob", "Joe" });

        //public ContentResult Index()
        //    => Content("[\"Alice\",\"Bob\",\"Joe\"]", "application/json");

        //public ObjectResult Index() => Ok(new string[] { "Alice", "Bob", "Joe" });

        //public VirtualFileResult Index()
        //    => File("/lib/twitter-bootstrap/css/bootstrap.css", "text/css");
        public StatusCodeResult Index()
                => StatusCode(StatusCodes.Status404NotFound);

        public ViewResult Result() => View((object)"Hello World");

        //public RedirectResult Redirect() => Redirect("/Example/Index");

        //public RedirectToRouteResult Redirect() =>
        //    RedirectToRoute(new
        //    {
        //        controller = "Example",
        //        action = "Index",
        //        ID = "MyID"
        //    });

        public RedirectToActionResult Redirect()
            => RedirectToAction(nameof(HomeController.Index), 
                                nameof(HomeController));
    }
}
