using Contract;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _studentRepo;
        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        [HttpGet("GetStudent")]
        public async Task<IEnumerable<Student>> GetStudent()
        {
            var student = await _studentRepo.GetStudent();
            return student;
        }

        [HttpGet("GetStudentByID")]
        public async Task<ActionResult<Student>> GetStudentByID(int id)
        {
            var student = await _studentRepo.GetStudentId(id);
            return student;
        }

        [HttpPost("CreateStudent")]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            Student student1 = new Student();
            if(student != null)
            {
                student.Id = 0;
                student1 = await _studentRepo.AddStudent(student);
            }
            return student1;
        }

        [HttpPut("UpdateStudent")]
        public async Task<ActionResult<Student>> UpdateStudent(Student stud)
        {
            var update = await _studentRepo.UpdateStudent(stud);
            return update;
        }

        [HttpDelete("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await _studentRepo.DeleteStudent(id);
            return NoContent();
        }
    }
}
