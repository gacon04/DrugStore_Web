using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugStore_Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Stock { get; set; }

        public int? CategoryId { get; set; } // Nullable cho quan hệ tùy chọn

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Optional: Navigation property nếu có bảng Category
        // public virtual Category Category { get; set; }
    }
}