/*
Q. Write a C# program that demonstrates the use of Method overloading and method overriding.
*/

namespace OverloadingOverriding
{
    public class Multiply
    {
        public virtual int Operate(int x) => x * x;
        public string Operate(string x)
        {
            return x + " is appended.";
        }
    }
    public class MultiplyTwo : Multiply
    {
        public override int Operate(int x) => x * 2;
    }
    public class MultiplyThree : Multiply
    {
        public override int Operate(int x) => x * 3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Multiply multiply = new Multiply();
            MultiplyTwo multiplyTwo = new MultiplyTwo();
            MultiplyThree multiplyThree = new MultiplyThree();
            Console.WriteLine($"Multiply = {multiply.Operate(1)}");
            Console.WriteLine($"Multiply = {multiply.Operate("Norden")}");
            Console.WriteLine($"MultiplyTwo = {multiplyTwo.Operate(2)}");
            Console.WriteLine($"MultiplyThree = {multiplyThree.Operate(2)}");
        }
    }
}