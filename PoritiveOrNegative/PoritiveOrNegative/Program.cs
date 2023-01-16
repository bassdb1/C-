using System;

namespace PoritiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("is positive");
            else
                Console.WriteLine("is negative");
        }
    }
}
