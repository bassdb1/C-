using System;

namespace CheckAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age - ");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age > 30)
            {
                var message1 = "You look younger than ";
                Console.WriteLine();
                Console.Write(message1 + age);
            }
            else
            {
                var message2 = "You look older than ";
                Console.WriteLine();
                Console.Write(message2 + age);
            }               


        }
    }
}
