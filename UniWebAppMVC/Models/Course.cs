using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniWebAppMVC.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseCode { get; set; }

        public string CourseName { get; set; }

        public double CreditHour { get; set; }

        public string CourseDescription { get; set; }

        public int SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public virtual Semester SemesterDropdown { set; get; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department DepartmentDropdown { set; get; }
    }
}