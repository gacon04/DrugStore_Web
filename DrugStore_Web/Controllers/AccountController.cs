using DrugStore_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore_Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WishList()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        
    }
}