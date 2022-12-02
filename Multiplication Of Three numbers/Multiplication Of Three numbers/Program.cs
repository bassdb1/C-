using System;

namespace Multiplication_Of_Three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            string num1 = Console.ReadLine();
            Console.Write("Input the second number to multiply: ");
            string num2 = Console.ReadLine();
            Console.Write("Input the third number to multiply: ");
            string num3 = Console.ReadLine();
            int sum = int.Parse(num1) * int.Parse(num2) * int.Parse(num3);
            Console.WriteLine();
            Console.WriteLine(num1 + " x " + num2 + " x " + num3 + " = "+ sum);
        }
    }
}
