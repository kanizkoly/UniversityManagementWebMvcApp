using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniWebAppMVC.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string Name { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [Remote("IsEmailExist", "Teachers", ErrorMessage = "This email already exists. Please enter a different email.")]

        public string Email { get; set; }

        public string ContactNo { get; set; }

        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation DesignationDropdown { set; get; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department DepartmentDropdown { set; get; }

        public decimal CreditToBeTaken { get; set; }
    }
}