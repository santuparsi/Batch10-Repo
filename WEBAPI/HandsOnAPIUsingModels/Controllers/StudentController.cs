using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModels.Models;
using HandsOnAPIUsingModels.Repositories;
namespace HandsOnAPIUsingModels.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        //Inject studentRepository object o StudentControllers using DI
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        //Endpoints
        // api/Student
        [HttpGet]
        public List<Student> GetStudents()
        {
            return studentRepository.GetStudents();
        }
        [HttpGet("{id}")] //id value should pass using url at runtime
        // api/Student/2
        public Student GetStudent(int id)
        {
            return studentRepository.GetStudent(id);
        }
        [HttpPost]
        public void AddStudent(Student student)
        {
            studentRepository.AddStudent(student);
        }
    }
}
