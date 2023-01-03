using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Character_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // remove specified character from a non-empty string using index of a character

            // How this works - it starts at line 14, calls remove_char 'Method' passing in  'w3resource' into 'str' and 1 into 'int n' of the remove_char method

            Console.WriteLine(remove_char("w3resource", 1));    // w3resource is the argument
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));


        }
        // remove_char Method
        public static string remove_char(string str, int n)  // 
        {
            // this will 'return to Console.Writeline statement with characters removed by theor indes, starting with 0 index
            return str.Remove(n,1);       // n = which charcter we are removing.  1= is the length of the characters being removed, so 1 character
        }                                 // str = "w3resource" the string argument we are passing to the 'remove_char' method 
    }
}
