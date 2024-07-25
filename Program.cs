
using System;
namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Result;
            Console.WriteLine("Enter First Number:");
            Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            Number2 = int.Parse(Console.ReadLine());
            if (Number2 == 0)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            else
            {
                Result = Number1 / Number2;
                Console.WriteLine($"Result = {Result}");
            }
            Console.ReadKey();
        }
    }
}
// in this program if the second number entered is 0, so the program returns an custom exception instead of a error