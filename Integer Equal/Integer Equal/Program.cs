using System;

namespace Integer_Equal
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

            //Check if num1 and num2 are equal

            if (num1 == num2 )
            {
                var sum = (num1 + num2) * 3;
                Console.WriteLine("Since first integer {0} and second integer {1} are the same, we are going to tripe the sum = {2} ",num1,num2, sum );
            }
           
            else
            {
                var sum = (num1 + num2);
                Console.WriteLine("The sum of the first integer {0} and the second integer {1} = {2}" ,num1, num2, sum);
            }

        }
    }
}
 