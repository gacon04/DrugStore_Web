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
        public ActionResult ThongTinTaiKhoan(int id)
        {
            string tenChuTaiKhoan = "";
             
            TaiKhoan[] TaiKhoans = new[]
            {
                new TaiKhoan{IdTaiKhoan=1, ChuTaiKhoan="Nguyen Van A", SoDu=-5000},
                new TaiKhoan{IdTaiKhoan=2, ChuTaiKhoan="Nguyen Van B", SoDu=3000},
                 new TaiKhoan{IdTaiKhoan=3, ChuTaiKhoan="Nguyen Van C", SoDu=1000}
            };
            foreach (TaiKhoan tk in TaiKhoans)
            {
                   if (tk.IdTaiKhoan==id)
                {
                    tenChuTaiKhoan = tk.ChuTaiKhoan;
                }    
            }
            ViewBag.ChuTaiKhoan =tenChuTaiKhoan;

            return View();
        }
    }
}