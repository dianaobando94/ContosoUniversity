using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using ContosoUniversity.Data;

namespace ContosoUniversity.Repositories.Implements
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SchoolContext context) : base(context)
        {

        }
    }
}
