﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using ContosoUniversity.Repositories;

namespace ContosoUniversity.Services.Implements
{
    public class OfficeAssignmentService : GenericService<OfficeAssignment>, IOfficeAssignmentService
    {
        private IOfficeAssignmentRepository officeAssignmentRepository;

        public OfficeAssignmentService(IOfficeAssignmentRepository officeAssignmentRepository) : 
            base(officeAssignmentRepository)
        {
            this.officeAssignmentRepository = officeAssignmentRepository;
        }
    }
}
