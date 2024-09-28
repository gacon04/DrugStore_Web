using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrugStore_Web.Models;
namespace DrugStore_Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult AllProducts()
        {
            return View();
        }
        public ActionResult GetAllCategory()
        {
            using (DrugStoreDBContext db = new DrugStoreDBContext())
            {
                List<Category> categories = db.Categories.ToList();
                return View(categories); 
            }
        }
    }
}