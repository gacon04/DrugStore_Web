using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DrugStore_Web.Models
{
    public class DrugStoreDBContext: DbContext
    {
        public DrugStoreDBContext() : base("DSConnectionString") {  }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<TinNhanLienHe> TinNhanLienHes { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}