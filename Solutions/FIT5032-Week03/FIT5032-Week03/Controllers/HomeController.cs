using FIT5032_Week03.Exercise;
using FIT5032_Week03.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // I commented this line out
            //ViewBag.Message = "Your application description page.";

            // I created an instance of the Hello object
            Hello hello = new Hello();

            // I assigned the ViewBag.Message to the result of the the getHello result.
            ViewBag.Message = hello.GetHello();

            ExampleDictionary ed = new ExampleDictionary();

            ed.Example();
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}