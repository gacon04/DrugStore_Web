using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugStore_Web.Models
{
    public class GioHang
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MaNguoiDung { get; set; } // Khóa ngoại liên kết tới bảng Users

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}