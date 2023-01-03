using System;

namespace convert_from_celsius_degrees_to_Kelvin_and_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of Celsius: ");
            var ctemp = Console.ReadLine();
            int celsius = Convert.ToInt32(ctemp);


            // Convert Celsious to Kelvin and Fahrenheit

            var kelvin = celsius + 273;
            var fahrenheit = ((celsius * 9 / 5) + 32);

            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
        }
    }
}
