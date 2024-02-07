using Contract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentContext _studentContext;
        public StudentRepo(StudentContext studentContext)
        {
            _studentContext = studentContext; 
        }
        public async Task<Student> AddStudent(Student student)
        {
            var result = await _studentContext.StudentsDetail.AddAsync(student);
            await _studentContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStudent(int StudId)
        {
            var result = await _studentContext.StudentsDetail.FirstOrDefaultAsync(s=>s.Id == StudId);
            if(result != null)
            {
                _studentContext.StudentsDetail.Remove(result);
                await _studentContext.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<Student>> GetStudent()
        {
            return await _studentContext.StudentsDetail.ToListAsync();
        }

        public async Task<Student> GetStudentId(int studId)
        {
            return await _studentContext.StudentsDetail.FirstOrDefaultAsync(s => s.Id == studId);

        }

        public async Task<Student> UpdateStudent(Student student)
        {
            var result = await _studentContext.StudentsDetail.FirstOrDefaultAsync(s => s.Id == student.Id);
            if(result != null)
            {
                result.Name = student.Name;
                result.City = student.City;
                await _studentContext.SaveChangesAsync();
            }
            return result;
        }
    }
}
