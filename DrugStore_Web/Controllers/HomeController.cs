using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Đây là trang giới thiệu về nhà thuốc.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Đây là trang liên hệ nhà thuốc.";

            return View();
        }
    }
}