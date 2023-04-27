using System;

namespace HelloWorld
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
            set {  firstName = value; }
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
            Console.WriteLine("Fullname is: " + FullName + "\nSalary is: " + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Radhe = new Employee("Radhe", "Futsal", 20000.55);
            Console.WriteLine("Full Name: " + Radhe.FullName);
            Console.WriteLine("Salary: " + Radhe.Salary);
            Radhe.IncrementSalary(10);
            Radhe.Display();
        }
    }
}