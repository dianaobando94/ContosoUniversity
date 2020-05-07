using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.DTOs
{
    public class StudentDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The is Last Name requiered")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The is First Mid Name requiered")]
        [Display(Name = "First Mid Name")]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = "The is Enrollment Date requiered")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
}
