using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InvoiceSystem.dal;
using InvoiceSystem.Models;

namespace InvoiceSystem.Initializer
{
    public class StudentInitializer : System.Data.Entity.DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i < 40; i++)
            {
                Student student = new Student();
                student.ID = i;
                student.Name = "张" + i;
                student.Age = 10 + i;
                student.Sex = i % 2 == 0 ? Sex.Female : Sex.Male;
                student.Score = 60 + i;

                students.Add(student);
            }

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}