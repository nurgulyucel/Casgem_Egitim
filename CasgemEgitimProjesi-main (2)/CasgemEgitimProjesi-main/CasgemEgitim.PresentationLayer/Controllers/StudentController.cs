﻿using CasgemEgitim.BusinessLayer.Abstract;
using CasgemEgitim.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CasgemEgitim.PresentationLayer.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var values = _studentService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentService.TInsert(student);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteStudent(int id)
        {
            var values = _studentService.TGetById(id);
            _studentService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var values = _studentService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            var values = _studentService.TGetById(student.StudentID);
            values.StudentName = student.StudentName;
            values.StudentSurname = student.StudentSurname;
            values.Username = student.Username;
            values.ImageUrl = student.ImageUrl;
            values.Password = student.Password;
            _studentService.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
