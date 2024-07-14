using System;
using System.Globalization;
using System.Threading;

namespace startingAgain 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your new password: ");
            string password = Console.ReadLine();


            Console.Write("Confirm your password: ");
            string passwordConfirm = Console.ReadLine();

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(passwordConfirm))
                Console.WriteLine(password.Equals(passwordConfirm) ? "Password match!" : "Password do not match!"); 
            
            else
                Console.WriteLine("Please, enter a password.");
         
        }
    }
}
