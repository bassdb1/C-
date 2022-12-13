using System;

namespace Math_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user

            
            Console.Write("Enter the First number: ");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            var number3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            var number4 = Convert.ToDouble(Console.ReadLine());
            var average = ((number1 + number2 + number3 + number4) /4) ;

            Console.WriteLine("The average of {0}, {1}, {2}, {3}, is: {4} ", number1, number2, number3, number4, average);



        }
    }
 }

