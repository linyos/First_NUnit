using System;

namespace ConsoleApp1
{

    public class Example
    {

        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
