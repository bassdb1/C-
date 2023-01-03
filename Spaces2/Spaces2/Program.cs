using System;

namespace Spaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Console.ReadLine();

            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
        }
    }
    
}


