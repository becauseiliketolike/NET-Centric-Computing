/*
LAB-1:

WAP to create class Employee with the following specification.
    a. Field name: firstName, lastName, salary
    b. Properties: FirstName, LastName, FullName, Salary
    c. Parameterized Constructor
    d. Method: 
        - IncrementSalary(double s)
        - Display() // for showing details of employee
    e. Now, create an object e1 of this class and show use of 
        - Constructor
        - Display fullname and salary using Properties
        - Change the first name
        - Increment the salary by 10%
        - Display fullname and salary by calling method

*/


using System;

namespace Employee
{
    public class Employee
    {
        public string firstName, lastName;
        public double salary;

        public Employee(string firstName, string lastName, double salary) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return firstName; } 
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value;  }
        }

        public void IncrementSalary(double s) 
        { 
            salary += (s/100) * salary;
        }

        public void Display()
        {
            Console.WriteLine("Fullname: " + FullName + "\nSalary: " + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ram", "Cena", 20000.55);
            Console.WriteLine("Full Name: " + e1.FullName);
            Console.WriteLine("Salary: " + e1.Salary);
            e1.FirstName = "John";
            e1.LastName = "Shyam";
            e1.IncrementSalary(10);
            e1.Display();
        }
    }
}
