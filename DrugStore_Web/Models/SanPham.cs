using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugStore_Web.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string TenSP { get; set; }

        public string MieuTa { get; set; }

        [Required]
        public double Gia { get; set; }

        [Required]
        public int ConHang { get; set; }

        public int? MaDanhMuc { get; set; } // Nullable cho quan hệ tùy chọn

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime NgayTao { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CapNhat { get; set; } = DateTime.Now;

        // Optional: Navigation property nếu có bảng Category
        // public virtual Category Category { get; set; }
    }
}