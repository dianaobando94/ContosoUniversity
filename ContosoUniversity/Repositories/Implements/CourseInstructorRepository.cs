﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using ContosoUniversity.Data;

namespace ContosoUniversity.Repositories.Implements
{
    public class CourseInstructorRepository : GenericRepository<CourseInstructor>, ICourseInstructorRepository
    {
        public CourseInstructorRepository(SchoolContext context) : base(context)
        {

        }
    }
}
