using System;

namespace Spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            var digit = Console.ReadLine();

            Console.WriteLine("{0} {0} {0} {0}", digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);
            Console.WriteLine("{0} {0} {0} {0}", digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);

        }
    }
}
