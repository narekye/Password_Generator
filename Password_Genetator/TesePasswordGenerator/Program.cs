using System;
using PasswordGenerator; // add this 'using' to use class library.

namespace TestPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            //Parameter is lenght of your own password. Example 1.
            string mypassword = Password.Generate(45);
            Console.WriteLine("\t First password with length 4 | {0}", mypassword);
            // Or second one example below. Example 2
            Console.WriteLine("\t Second password with length 12 | {0}", Password.Generate(12));
            var mypass = new HardPassword();
            Console.WriteLine("\t Instance created by non-static class | {0}" ,mypass.Generate(34));
            mypass.Generate(12);
            // Delay !!
            Console.Read();
        }
    }
}
