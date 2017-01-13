using System;
using PasswordGenerator; // add this 'using' to use class library.

namespace TestPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            //Parameter is lenght of your own password. Example 1.
            string mypassword = Password.Generate(4);
            Console.WriteLine(mypassword);
            // Or second one example below. Example 2
            Console.WriteLine(Password.Generate(12));
            // Delay !!
            Console.Read();
        }
    }
}
