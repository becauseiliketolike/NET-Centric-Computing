using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Students
{

    public class Student
    {
        int id, age, studentClass;
        string name, address;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set ; }

        public int StudentClass { get; set; }

        public int Age { get; set; }

     
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>() 
            {
                new Student() { Id = 1, Name = "Shubha Pradhan", Address = "Budanilkantha", StudentClass = 10, Age = 21  },
                new Student() { Id = 2, Name = "John Doe", Address = "Gulmi", StudentClass = 12, Age = 23 },
                new Student() { Id = 3, Name = "Norden", Address = "Bhaktapur", StudentClass = 8, Age = 18 } 
            };

            var studentAddresses = from student in students where student.Name == "John Doe" select student;

            foreach(var studentAdress in studentAddresses) 
            { 
                Console.WriteLine(studentAdress.Address);
            }

            foreach (var student in students)
            {
               Console.WriteLine(student.Name);
            }
        }
    }
}