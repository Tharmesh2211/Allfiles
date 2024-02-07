using Entities.Models;
using System.Numerics;

namespace Contract
{
    public interface IStudentRepo
    {
        Task<IEnumerable<Student>> GetStudent();
        Task<Student> GetStudentId(int studId);
        Task<Student> AddStudent(Student student);
        Task<Student> UpdateStudent(Student student);
        Task DeleteStudent(int StudId);
    }
}
