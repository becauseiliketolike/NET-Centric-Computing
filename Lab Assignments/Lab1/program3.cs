/*
Q. Write a C# program that demonstrates the use of delegates to perform arithmetic operations.
*/

namespace Delegate
{
    public class Arithmetic
    {
        public delegate int ArithmeticDelegate(int x, int y);
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            Arithmetic.ArithmeticDelegate add = arithmetic.Add;
            Arithmetic.ArithmeticDelegate sub = arithmetic.Sub;
            Arithmetic.ArithmeticDelegate mul = arithmetic.Mul;
            Arithmetic.ArithmeticDelegate div = arithmetic.Div;
            Console.WriteLine($"Addition = {add(5, 4)}");
            Console.WriteLine($"Subtraction = {sub(7, 2)}");
            Console.WriteLine($"Multiplication = {mul(2, 2)}");
            Console.WriteLine($"Division = {div(9, 4)}");
        }
    }
}