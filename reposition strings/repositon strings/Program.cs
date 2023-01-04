using System;

namespace repositon_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
                

       

            Console.WriteLine(first_last("w3resource"));    // w3resource is the argument
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));


        }
        // first_last Method
        public static string first_last(string str)  // 
    {
        
        return str.Length > 1
                  ? str.Substring(str.Length -1 ) + str.Substring(1,str.Length - 2) + str.Substring(0,1) : str;  // ternary operator '?' = if, ':' = else

                //  ?  str.Substring(str.Length - 1) : str; -- Returns 'e'

                // ? str.Substring(1, str.Length - 2) : str;  // going to take out 'w' because where the index 1 is, that is -1, the str.Length -1 will take out the 'e' from 'w3resource'
                                                             //                                          --Returns '3rsesours'

                // ? str.Substring(0, 1) : str;            --Returns 'w'

                // when you add all together '+' you get   (e + 3resoursw + w)  = 'e3resoursw'



        }









    }
}
