# Working with password generator class library.
### You do not need to create a instance of `Password` class, because its imposible create instance of static class.
### Use for generate many random passwords, which can improve you to secure somewhat.
___
## How to add the `Password` class library in your project shown below.
![How to add the class library](https://github.com/narekye/Password_generator/blob/master/GIF.gif)
Created class library with name `PasswordGenerator`(you must add the `using PasswordGenerator;`)which contains one `static class` which contains 1 staic field and 1 static method.
Method has 1 parameter which is the **length** of password.
In snippet shown the `static class` with his members.
```C#
using System;
namespace PasswordGenerator
{
    /// <summary>
    /// This class library used for generate random passwords. 
    /// Used all digits, uppercase and downcase letters.
    /// Can send any parameter to 'Generate' method, which will generate password with sended count length.
    /// </summary>
    public static class Password
    {
        private static string pass = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static string Generate(int length)
        {
            Random Rdpass = new Random();
            string password = String.Empty;
            for (int i = 0; i < length; i++)
            {
                password += pass[Rdpass.Next(0, pass.Length)];
            }
            return password;
        }
    }
}
```
In the solution have added new project where testing class library. The testing was completed in `Console` application.
```C#
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
```
### In this picture shown result of testing in console window.
![Result](https://github.com/narekye/Password_generator/blob/master/passwordsnippet.JPG)
___
For more information [contact](https://github.com/narekye).
