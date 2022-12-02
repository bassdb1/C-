using System;
using System.Threading;   // This is needed to use threading

// Source = https://www.partech.nl/nl/publicaties/2021/02/multi-threading-in-c-sharp#

namespace MultiThread
{
    class Program
    {

        public static void ForwardNumbering()
        {
            for (var i =1; i<=10; i++)
            {
                Console.WriteLine("Forward - " + i.ToString());
            }
        }

        public static void ReverseNumbering()
        {
           for (var j=10; j>=1; j--)
            {
                Console.WriteLine("Reverse - " + j.ToString());
            }
        }
        static void Main(string[] args)
        {
            // Calling the methods Normally

            // ForwardNumbering();
            // ReverseNumbering();

            // Calling the methods in parallel using threads

           
            var thread1 = new Thread(ForwardNumbering);  // making a thread1 object
            var thread2 = new Thread(ReverseNumbering);  // making a thread2 object

            thread1.Start();
            thread2.Start();
        }
    }
}
