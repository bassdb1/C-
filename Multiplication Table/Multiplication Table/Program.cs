using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user

            var length = 11;
            Console.Write("Enter the number: ");
            string num1 = Console.ReadLine();
            int number = int.Parse(num1);

            // Print out the Multiplication Table
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                int sum = number * i;
                Console.WriteLine(num1 + " * " + i + " = " + sum);
            }
        }
    }
}
