/*
 using System;
using System.Collections.Generic;
using System.Linq;

namespace startingAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();
            string continueOn;
            
            Console.WriteLine("Welcome to the program! Enter a series of numbers to calculate the minimum, maximum, and average of the list.");
           
            // Do-while loop to allow user to enter multiple numbers
            do
            {
                int value;
                Console.Write("Please enter a number: ");
                
                // Validating input
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Please enter a number: ");
                }

                // Add the valid number to the list
                listOfNumbers.Add(value);

                // Ask if the user wants to add another number
                Console.Write("Do you want to add another number (y/n): ");
                continueOn = Console.ReadLine().ToLower().Trim();

            } while (continueOn != "n");

            // Calculate and display the maximum, minimum, and average values
            Console.WriteLine($"Maximum value in the list: {listOfNumbers.Max()}");
            Console.WriteLine($"Minimum value in the list: {listOfNumbers.Min()}");
            Console.WriteLine($"Average value of the list: {listOfNumbers.Average()}");
        }
    }
}



Key Improvements:
Single Input for Numbers: Instead of asking for two numbers at a time, it might be more user-friendly to allow the user to enter one number at a time.
Variable Scope: The secondValue variable is not needed if you only take one number at a time.
Input Validation: Prompt the user for a number and add it to the list immediately after validation.
Code Readability: Improve readability by adding comments and organizing the code logically.

 */


using System;
using System.Net.Security;

namespace  startingAgain 
{
    class Program
    {
        //Values need to be declared as a static to be available in different parts of the program.
        static int value, secondValue;
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>(); 
            string continueOn;
            
            Console.WriteLine("Welcome to the program, we need you to enter a variety (one in each input) of numbers to have the min, max, and average of the list of numbers.");
           
            //Do-while for maintaining the program running in case of user wants to add more than two numbers.
            do
            {
                Console.Write("Please enter a number: ");
               //validating input 
               while(!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Please, enter one number in each input.");
                    Console.Write("Please enter a number: ");
                }

                Console.Write("Please enter a number: ");
                //validating input 
                while (!int.TryParse(Console.ReadLine(), out secondValue))
                {
                    Console.WriteLine("Please, enter one number in each input.");
                    Console.Write("Please enter a number: ");
                }

                listOfNumbers.Add(value);
                listOfNumbers.Add(secondValue);

                Console.Write("Do you want to add another number (y/n): ");
                continueOn = Console.ReadLine().ToLower().Trim();


            } while (continueOn != "n");
            
             Console.WriteLine($"This is the max value in the list: {listOfNumbers.Max()} \nThis the minimum value in the list: {listOfNumbers.Min()} \nThis is the average value of the list: {listOfNumbers.Average()}");       
        }



    }
}
