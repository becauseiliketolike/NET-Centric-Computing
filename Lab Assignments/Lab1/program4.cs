/*
Q. Write a C# program using lambda expressions that performs basic mathematical operations on two numbers.
*/

namespace Delegate
{
    class Program
    { 
        public delegate int ArithmeticDelegate(int a, int b);
        static void Main(string[] args)
        {
            ArithmeticDelegate add = (a, b) => a + b;
            ArithmeticDelegate sub = (a, b) => a - b;
            ArithmeticDelegate mul = (a, b) => a * b;
            ArithmeticDelegate div = (a, b) => a / b;
            Console.WriteLine($"Addition = {add(1, 4)}");
            Console.WriteLine($"Subtraction = {sub(5, 6)}");
            Console.WriteLine($"Multiplication = {mul(7, 2)}");
            Console.WriteLine($"Division = {div(9, 3)}");
        }
    }
}