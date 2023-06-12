/*
Q. Write a C# program to handle the potential exception that may occur in a program.
*/

using System;

namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            int dividend, divisor, quotient;
            Console.Write("Enter dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());
            try
            {
                quotient = dividend / divisor;
                Console.WriteLine($"The quotient is {quotient}");
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}