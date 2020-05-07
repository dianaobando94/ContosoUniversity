﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using ContosoUniversity.Repositories;

namespace ContosoUniversity.Services.Implements
{
    public class StudentService : GenericService<Student>, IStudentService
    {
        private IStudenRepository studenRepository;

        public StudentService (IStudenRepository studenRepository) : base(studenRepository)
        {
            this.studenRepository = studenRepository;
        }


    }
}
