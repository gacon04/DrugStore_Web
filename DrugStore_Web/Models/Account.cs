using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DrugStore_Web.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(255)] 
        public string Address { get; set; }

        [Required]
        [EmailAddress] // Kiểm tra định dạng email
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)] 
        public string Password { get; set; }

        [Required]
        [StringLength(50)] 
        public string Role { get; set; }
    }
}