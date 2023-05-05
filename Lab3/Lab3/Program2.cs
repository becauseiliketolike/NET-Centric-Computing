/*

LAB-3:

Create Generic List for students with studentID, name, address, class, age.
- Add the students.
- Filter the data via LINQ to find out
    1. Select all the students
    2. Select students who lives in kathmandu
    3. Select student who reads in BScCSIT and age<=25

*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace Student
{
    public class Student
    { 
        // public int studentID, age;
        // public string name, address, studentClass;

        public int StudentID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string StudentClass { get; set; }

        public int Age { get; set; }
        
        public void Display()
        {
            Console.WriteLine(StudentID + " " + Name + " " + Address + " " + StudentClass + " " + Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() 
            {
                new Student() { StudentID=1, Name="rishab", Address="kathmandu", StudentClass="BScCSIT", Age=24 },
                new Student() { StudentID=2, Name="shubha", Address="lalitpur", StudentClass="BScCSIT", Age=39 },
                new Student() { StudentID=3, Name="rabin", Address="kathmandu", StudentClass="BCA", Age=27 },
                new Student() { StudentID=4, Name="norden", Address="bhaktapur", StudentClass="BScCSIT", Age=23}
            };
            Console.WriteLine("1. Select all Students:");
            foreach (var student in students)
            {
                student.Display();
            }
            Console.WriteLine("\n2. Select students who lives in \"kathmandu\":");
            var kathmanduStudents = from student in students where student.Address == "kathmandu" select student;
            foreach (var kathmanduStudent in kathmanduStudents)
            {
                kathmanduStudent.Display();
            }
            Console.WriteLine("\n3. Select student who reads in BScCSIT and age<=25:");
            var studentsSubject = from student in students where (student.StudentClass == "BScCSIT") && (student.Age <= 25) select student;
            foreach (var studentSubject in studentsSubject)
            {
                studentSubject.Display();
            }
        }
    }
}
