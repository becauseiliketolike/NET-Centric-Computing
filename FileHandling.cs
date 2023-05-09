using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void ReadFile(ref string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public static void WriteFile(ref string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Enter content to write in file");
                string str = Console.ReadLine();
                writer.WriteLine(str);
            }
        }
        public static void Main(string[] args)
        {
            string filePath = "example.txt";
            WriteFile(ref filePath);
            ReadFile(ref filePath);
        }
    }
}