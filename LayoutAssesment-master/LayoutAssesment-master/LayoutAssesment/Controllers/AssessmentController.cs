using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAssesment.Controllers
{
    public class AssessmentController : Controller
    {
        // GET: Assessment
        public ActionResult Index()
        {
            List<String> Names = new List<String>
            {
                "sam","felix","laurence"
            };
            ViewBag.CNames = Names;
            return View();
        }
        public ActionResult DisplayMessage()
        {
            var message = TempData["message"] as string;
            ViewBag.Message = message;
            return View();
        }
        public ActionResult RedirectDemo()
        {
            TempData["message"] = " Welcome! Here are our valued customers:";
            return RedirectToAction("DisplayMessage");
        }
      





    }
}