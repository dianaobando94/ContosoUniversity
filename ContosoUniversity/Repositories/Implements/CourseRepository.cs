using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Services;
using ContosoUniversity.Repositories;

namespace ContosoUniversity.Repositories.Implements
{
    public class CourseRepository :GenericRepository<Course>, ICourseRepository
    {
        private SchoolContext schoolContext;
        public CourseRepository(SchoolContext schoolContext) : base(schoolContext) 
        {
            this.schoolContext = schoolContext;
        }

        public async Task<IEnumerable<Student>> GetStudentsByCourse(int id)
        {
            //SQL
            //SELECT S.*
            //FROM[dbo].[Enrollment]     E
            //JOIN[dbo].[Student] S ON S.ID	=	E.StudentID
            //WHERE E.CourseID = 4022;

            //var listStudents = await schoolContext.Enrollments
            //    .Include(x => x.Student)
            //    .Where(x => x.CourseID == id)
            //    .Select(x => x.Student)
            //    .ToListAsync();

            //var listStudentsMode = await schoolContext.Enrollments
            //    .Include(x => x.Student)
            //    .Where(x => x.CourseID == id)
            //    .Select(x => x.Student)
            //    .ToListAsync();

            var listStudents = await (from enrollment in schoolContext.Enrollments
                                      join student in schoolContext.Students on enrollment.StudentID equals student.ID
                                      where enrollment.CourseID == id
                                      select student).ToListAsync();

            return listStudents;
        }

         async Task IGenericRepository<Course>.Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new System.Exception("The entity is null");

            var flag = schoolContext.Enrollments.Any(x => x.CourseID == id);

            if (flag)
                throw new Exception("The course have enrroments");

            schoolContext.Courses.Remove(entity);
            await schoolContext.SaveChangesAsync();
        }
    }
}
