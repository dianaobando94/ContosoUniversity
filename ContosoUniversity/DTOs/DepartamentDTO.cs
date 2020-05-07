using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;

namespace ContosoUniversity.DTOs
{
    public class DepartamentDTO
    {
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "The DepartmentID is required")]
        [Display(Name = "Course ID")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The Course ID is required")]
        [Display(Name = "Course ID")]
        public decimal Budget { get; set; }

        [Required(ErrorMessage = "The Course ID is required")]
        [Display(Name = "Course ID")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "The Course ID is required")]
        [Display(Name = "Course ID")]
        public int InstructorID { get; set; }

        public Instructor Instructor { get; set; }
    }
}
