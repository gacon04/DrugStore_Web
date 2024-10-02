using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore_Web.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult GoogleMapLocations()
        {
            return View();
        }
        public ActionResult FAQ()
        {

            return View();
        }
        
    }
}