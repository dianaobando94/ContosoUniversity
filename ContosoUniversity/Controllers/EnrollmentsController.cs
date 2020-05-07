using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Models;
using ContosoUniversity.Repositories;
using ContosoUniversity.Services.Implements;
using ContosoUniversity.Services;

namespace ContosoUniversity.Controllers
{
    public class EnrollmentsController : Controller
    {
        private IEnrollmentService enrollmentServices;
        private IStudenRepository studentService;
        private ICourseService courseService;

        public EnrollmentsController(IEnrollmentService enrollmentServices, 
            IStudenRepository studentService, ICourseService courseService)
        {
            this.enrollmentServices = enrollmentServices;
            this.studentService = studentService;
            this.courseService = courseService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var listEnrollments = await enrollmentServices.GetAll();

            return View(listEnrollments);
        }

        public async Task<ActionResult> Create()
        {
            ViewBag.Courses = await courseService.GetAll();
            ViewBag.Students = await studentService.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Enrollment model)
        {

            ViewBag.Courses = await courseService.GetAll();
            ViewBag.Students = await studentService.GetAll();
            if (!ModelState.IsValid)
                return View(model);

            await enrollmentServices.Insert(model);

            return RedirectToAction("Index");

        }
    }
}