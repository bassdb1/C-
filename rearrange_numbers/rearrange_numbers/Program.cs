using System;

namespace rearrange_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user

            Console.Write("Enter the First number - ");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second number - ");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Third number - ");
            var number3 = Convert.ToDouble(Console.ReadLine());
            
            // Calculations

            var sum1 = (number1 + number2) * number3;
            var sum2 = (number1 * number2) + (number2 * number3);

            // Output

            Console.WriteLine();
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4} ", number1, number2, number3, sum1, sum2);

        }
    }
}
