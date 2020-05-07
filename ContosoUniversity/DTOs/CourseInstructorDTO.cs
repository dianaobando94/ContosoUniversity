using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.DTOs
{
    public class CourseInstructorDTO
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "The Course ID is required")]
        [Display(Name = "Course ID")]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "The Instructor ID  required")]
        [Display(Name = "Instructor ID")]
        public string InstructorID { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
