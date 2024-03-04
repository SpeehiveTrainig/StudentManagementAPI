﻿using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Db;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<StudentController>

        private readonly IStudentService _studentService;
        public StudentController()
        {
               
  
            _studentService = new StudentService(); //  remove new 
        }
        [HttpGet]
        public List<Student> GetList()
        {
            return _studentService.GetAll();

        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student studentDetail=_studentService.Get(id);
            return  studentDetail;
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post( Student value)
        {
            _studentService.Insert(value);

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // Explore
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            StudentManagementDbContext _dbContext = new StudentManagementDbContext();
            Student? selectedStudent = _dbContext.Students.Where(x => x.Id == id).FirstOrDefault();

            _dbContext.Students.Remove(selectedStudent);
            _dbContext.SaveChanges();
        }

        // change1
        // chnage2
    }
}
