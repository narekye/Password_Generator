# C# 6.0 VS 2015 | SW version 1.0 <img src="https://github.com/narekye/Password_generator/blob/master/C%23pic.png" align="right" width="150px" height="150px" /> 

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
# Whats new in second version | SW version 1.1
Added new `non-static` class named by `HardPassword` with new `non-static` method `Generate`.
### You can create instance of HardPassword class using default constructor, because user constructors n class haven't added.
There is a snippet of `non-static` class shown below.
```C#
 public class HardPassword
 {
     private string pass = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()-_=+|}{}:;',./";
     public string Generate(int length)
     {
         if (length>pass.Length)
          {
              throw new ArgumentOutOfRangeException("No much characters");
          }
          Random rdpass = new Random();
          string password = string.Empty;
          for (int i = 0; i < length; i++)
          {
              password += pass[rdpass.Next(rdpass.Next(i, pass.Length))];
          }
          return password; 
     }
}
```
Updated too the test project shown by Console Application.
```C#
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
      // Delay !!
      Console.Read();
}
```
The result in Console window shown in picture.
![result](https://github.com/narekye/Password_generator/blob/master/my.JPG)
## Updates soon.
For more information [contact](https://github.com/narekye).
___
# Have a fun.
![GIF](https://github.com/narekye/Password_generator/blob/master/giphy.gif)
