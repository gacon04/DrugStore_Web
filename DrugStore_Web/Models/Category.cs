using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugStore_Web.Models
{
    public class Category
    {
        // Khóa chính
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng IDENTITY(1,1)
        public int Id { get; set; }

        // Tên danh mục (bắt buộc)
        [Required]
        [StringLength(255)] // Đặt độ dài tối đa cho tên
        public string Name { get; set; }

        // ID danh mục cha (có thể null)
        public int? ParentId { get; set; }

        // Ngày tạo (mặc định là ngày hiện tại)
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Liên kết đến danh mục cha (nếu có)
        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }

        // Liên kết đến các danh mục con (nếu có)
        public virtual ICollection<Category> SubCategories { get; set; }
    }
}