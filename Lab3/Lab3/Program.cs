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
        public int studentID, age;
        public string name, address, studentClass;

        public Student(int studentID, string name, string address, string studentClass, int age)
        {
            this.studentID = studentID;
            this.name = name;
            this.address = address;
            this.studentClass = studentClass;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine(name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(1, "rishab", "kathmandu", "BScCSIT", 24),
                new Student(2, "shubha", "lalitpur", "BScCSIT", 39),
                new Student(3, "rabin", "kathmandu", "BCA", 27),
                new Student(4, "norden", "bakhtapur", "BScCSIT", 23)
            };
            Console.WriteLine("All Students:\n");
            foreach (var student in students)
            {
                student.Display();
            }
            Console.WriteLine("\nKathmandu Students:");
            var kathmanduStudents = from student in students where student.address == "kathmandu" select student;
            foreach (var kathmanduStudent in kathmanduStudents)
            {
                Console.WriteLine(kathmanduStudent.name);
            }
            Console.WriteLine("\nStudent Subject with age less than 25:");
            var studentsSubject = from student in students where (student.studentClass == "BScCSIT") && (student.age <= 25) select student;
            foreach (var studentSubject in studentsSubject)
            {
                Console.WriteLine(studentSubject.name);
            }
        }
    }
}