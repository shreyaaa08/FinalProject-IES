using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Api.Controllers
{
    #region StudentController
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students = new List<Student>()
            {
                new Student{StudentId =1, Firstname = "SHREYA", Lastname="SADANANDAN", UserName="shreya", Password ="123456"},
                new Student{StudentId =2, Firstname = "RIYA", Lastname="DESAI", UserName="riya", Password ="123456"},
                new Student{StudentId =3, Firstname = "ROSHEL", Lastname="VARGHESE", UserName="roshel", Password ="123456"},
                new Student{StudentId =4, Firstname = "AKSHATA", Lastname="HEGDE", UserName="akshata", Password ="123456"},
                new Student{StudentId =5, Firstname = "JUHI", Lastname="MANIKPURKAR", UserName="juhi", Password ="123456"}
            };

        // GET: api/AllStudents

        // GET: api/Student
        [HttpGet]
        [Authorize]
        public List<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        [Authorize]
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            Student s = null;
            students.ForEach(delegate (Student student)
            {
                if (student.StudentId == id)
                {
                    s = student;
                }
            });
            return s;
        }
    }
}
#endregion