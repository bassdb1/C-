using System;

namespace Math_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting Input from the user

            Console.Write("Input the first number to : ");
            string num1 = Console.ReadLine();
            Console.Write("Input the second number to : ");
            string num2 = Console.ReadLine();

            //Calculating the results

            int additonSum = int.Parse(num1) + int.Parse(num2);
            int subtractionSum = int.Parse(num1) - int.Parse(num2);
            int multiplicationSum = int.Parse(num1) * int.Parse(num2);
            int divisionSum = int.Parse(num1) / int.Parse(num2);
            Console.WriteLine();

            //Display the results

            Console.WriteLine(num1 + " + " + num2 + " = " + additonSum);
            Console.WriteLine(num1 + " - " + num2 + " = " + subtractionSum);
            Console.WriteLine(num1 + " * " + num2 + " = " + multiplicationSum);
            Console.WriteLine(num1 + " / " + num2 + " = " + divisionSum);
        }
    }
}
