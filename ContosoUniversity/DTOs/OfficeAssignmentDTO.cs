using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.DTOs
{
    public class OfficeAssignmentDTO
    {
        [Required(ErrorMessage = "The Instructo rID is required")]
        [Display(Name = "Instructor ID")]
        public int InstructorID { get; set; }

        [Required(ErrorMessage = "The Location  required")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }

    }
}
