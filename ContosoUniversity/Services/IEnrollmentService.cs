﻿using ContosoUniversity.Models;
using ContosoUniversity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Services
{
    public interface IEnrollmentService :IGenericService<Enrollment>
    {
    }
}
