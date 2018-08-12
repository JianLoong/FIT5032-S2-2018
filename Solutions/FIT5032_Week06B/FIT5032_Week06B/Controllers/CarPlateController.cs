using FIT5032_Week06B.Util;
using System;
using System.Web.Mvc;

namespace FIT5032_Week06B.Controllers
{
    public class CarPlateController : Controller
    {
        // GET: CarPlate
        public ActionResult Index()
        {
            return View();
        }

        // POST: CarPlate
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            try
            {
                // TODO: You can obtain values with form collections instead of model too.
                String state = formCollection["state"];
                String carPlate = formCollection["carPlate"];
                // Your logic here.

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CheckCarPlate(string carPlate, State state)
        {
            try
            {
                return Json(RegexLib.IsValidCarPlate(carPlate, state));
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
    }
}
