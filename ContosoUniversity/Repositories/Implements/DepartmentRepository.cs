using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Repositories.Implements
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private SchoolContext schoolContext;
        public DepartmentRepository(SchoolContext context) : base(context)
        {
            this.schoolContext = schoolContext;
        }

        public new async Task<List<Department>> GetAll()
        {
            var listDepartament = await schoolContext.Departments
                .Include(x => x.Instructor).ToListAsync();

            return listDepartament;
        }
    }
}
