using System;
using HandOnEFCodeFirst_Demo1.Entities;
using System.Collections.Generic;
using System.Linq;
namespace HandOnEFCodeFirst_Demo1
{
    class Program
    {
        public static void AddStudent()
        {
            using (Batch10DBContext db = new Batch10DBContext())
            {
                //Add Student Record
                Student student = new Student() { Age = 10, Name = "Suren" };
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
        public static void GetStudent(int id)
        {
            using (Batch10DBContext db = new Batch10DBContext())
            {
                Student student = db.Students.Find(id); //Find() serach record from table using pk column
                Console.WriteLine($"Name:{student.Name} Age:{student.Age}");
            }
        }
        public static void GetStudents()
        {
            using (Batch10DBContext db = new Batch10DBContext())
            {
                List<Student> studetns = db.Students.ToList(); //return all the students
                foreach(var student in studetns)
                Console.WriteLine($"Name:{student.Name} Age:{student.Age}");
            }
        }
        static void Main(string[] args)
        {
            // AddStudent();
            // GetStudent(1);
            GetStudents();
        }
    }
}
