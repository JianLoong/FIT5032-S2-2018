using System;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week06C.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SessionCookieDemo()
        {
            ViewBag.Title = "Session and Cookie Demo";
            return View();
        }

        [HttpPost]
        public ActionResult SessionCookieDemo(FormCollection formCollection)
        {
            Session["Demo"] = formCollection["session"];
            HttpCookie myCookie = new HttpCookie("UserSettings");
            myCookie["Cookie"] = formCollection["cookie"];
            myCookie.Expires = DateTime.Now.AddDays(1d);
            Response.Cookies.Add(myCookie);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = Session["Demo"];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            if (Request.Cookies["UserSettings"] != null)
            {
                var value = Request.Cookies["UserSettings"];
                var storedValue = value["Cookie"];
                ViewBag.Message = "Your cookie value is " + storedValue;
            }

            return View();
        }
    }
}