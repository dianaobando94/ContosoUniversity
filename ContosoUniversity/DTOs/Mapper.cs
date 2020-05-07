using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.DTOs;
using ContosoUniversity.Models;


namespace ContosoUniversity.DTOs
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>();

            CreateMap<CourseDTO, Course>();
            CreateMap<Course, CourseDTO>();


            CreateMap<EnrollmentDTO, Enrollment>();
            CreateMap<Enrollment, EnrollmentDTO>();


            CreateMap<InstructorDTO, Instructor>();
            CreateMap<Instructor, InstructorDTO>();


            CreateMap<CourseInstructorDTO, CourseInstructor>();
            CreateMap<CourseInstructor, CourseInstructorDTO>();


            CreateMap<DepartamentDTO, Department>();
            CreateMap<Department, DepartamentDTO>();


            CreateMap<OfficeAssignmentDTO, OfficeAssignment>();
            CreateMap<OfficeAssignment, OfficeAssignmentDTO>();


        }

    }
}
