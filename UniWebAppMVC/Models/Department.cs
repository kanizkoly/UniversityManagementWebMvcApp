using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniWebAppMVC.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }
        [Required]
        [Display(Name = "Department Code")]
        [Remote("IsDepartmentCodeExist", "Departments", ErrorMessage = "Department code already exists. Please enter a different department code.")]
        public string DepartmentCode { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        [Remote("IsDepartmentNameExist", "Departments", ErrorMessage = "Department name already exists. Please enter a different department name.")]
        public string DepartmentName { get; set; }
    }
}