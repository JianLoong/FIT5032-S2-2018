using SignalRChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week08C.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ToDo()
        {
            return View();
        }

        public ActionResult Index()
        {
            ToDoHub.AdminSend("Someone entered");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}