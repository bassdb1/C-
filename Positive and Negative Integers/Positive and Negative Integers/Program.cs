using System;

namespace Positive_and_Negative_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get Input
            Console.WriteLine("Input first integer:");
            var int1 = Console.ReadLine();
            Console.WriteLine("Input second integer:");
            var int2 = Console.ReadLine();

            // Convert String to Int
            int num1 = Int32.Parse(int1);
            int num2 = Int32.Parse(int2);

            //Check if num1 and num2 are both negative and postive

            if (num1> 0 && num2<0)
            {
                Console.WriteLine("True");
            }
            else if(num2> 0 && num1 < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
