using ContosoUniversity.Models;
using ContosoUniversity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Services.Implements
{
    public class EnrollmentServices : GenericService<Enrollment>, IEnrollmentService
    {
        private IEnrollmentRepository enrollmentRepository;

        public EnrollmentServices(IEnrollmentRepository enrollmentRepository) : base (enrollmentRepository)
        {

        }
    }
}
