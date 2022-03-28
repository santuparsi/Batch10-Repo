using HandsOnAPIUsingModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingModels.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public static List<Student> students=new List<Student>() { 
        new Student(){StudentId=1,StudentName="Ram",Age=12}
        };

        public void AddStudent(Student student)
        {
            //Add student
            students.Add(student);
        }

        public Student GetStudent(int id)
        {
            // return students.SingleOrDefault(s => s.StudentId == id);
            return (from s in students where s.StudentId == id select s).SingleOrDefault();
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
