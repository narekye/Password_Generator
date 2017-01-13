using System;
namespace PasswordGenerator
{
    /// <summary>
    /// This class library used for generate random passwords. 
    /// Used all digits, uppercase & downcase letters.
    /// Can send any parametr to 'Generate' method which will generate password with sended count length.
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
