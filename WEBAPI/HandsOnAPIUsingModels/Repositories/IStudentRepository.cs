using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
    }
}
