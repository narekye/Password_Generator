using System;
using System.Runtime.Remoting.Messaging;

namespace PasswordGenerator
{
    /// <summary>
    /// This class used for generate random passwords. 
    /// Used all digits, uppercase & downcase letters.
    /// Can send any parametr to 'Generate' method which will generate password with sended count length.
    /// </summary>
    public static class Password
    {
        private static string pass = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static string Generate(int length)
        {
            if (length > pass.Length)
            {
                throw new ArgumentOutOfRangeException("No much characters");
            }
            Random Rdpass = new Random();
            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                password += pass[Rdpass.Next(0, pass.Length)];
            }
            return password;
        }
    }
    /// <summary>
    /// This class used for generate random passwords.
    /// Used all digits,uppercase and downcase letters with all symbols.
    /// With this class you can create the instance of HardPassword and use.
    /// </summary>
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

        public static string ToUpperPassword(string a)
        {
            return a.ToUpper();
        }
    }
}
