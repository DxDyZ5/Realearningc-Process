using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;


namespace startingAgain 
{
    class Program 
    {
        static int year;
        
        static void Main(string[] args)
        {
            validateYearInput();

           while (!(year > DateTime.MinValue.Year && year < DateTime.MaxValue.Year)) //Looping until the input is a valid year according to c# DateTime type.
           {
                Console.WriteLine("Year is not valid. Try with any value greater than 0 and less than 9999");
                validateYearInput();
           }
           IsLeapYearOrnot(year);
        }
            

        static void validateYearInput() {
            
            Console.Write("Please, enter a year: ");
            while (!int.TryParse(Console.ReadLine(), out year)) //Check if the variable year is a valid integer
            {
                Console.WriteLine("No valid input. Try again");
                Console.Write("Please, enter a year: ");
            }
        }

        static void IsLeapYearOrnot(int year)
        {
            Console.WriteLine(year % 4 == 0 ? $"The year {year} is leap" : $"The year {year} is not leap"); //Check whether year is leap or not by using %.
        }
    }




    /*Fix code:
     using System;

namespace startingAgain
{
    class Program
    {
        static int year;
        
        static void Main(string[] args)
        {
            ValidateYearInput();

            while (year <= 0 || year > 9999) // Looping until the input is a valid year
            {
                Console.WriteLine("Year is not valid. Please enter a value between 1 and 9999.");
                ValidateYearInput();
            }

            CheckLeapYear(year);
        }
        
        static void ValidateYearInput() 
        {
            Console.Write("Please, enter a year: ");
            while (!int.TryParse(Console.ReadLine(), out year)) // Check if the variable year is a valid integer
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                Console.Write("Please, enter a year: ");
            }
        }

        static void CheckLeapYear(int year)
        {
            // Improved leap year calculation
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine(isLeap ? $"The year {year} is a leap year." : $"The year {year} is not a leap year.");
        }
    }
}



    //////////////////////////////////////////////////////

    Explanation of Changes:
Simplified Leap Year Calculation:

The updated CheckLeapYear method uses the correct rules for determining a leap year:
A year is a leap year if it is divisible by 4, but not by 100, unless it is also divisible by 400.
This ensures that the calculation accounts for all edge cases.
Variable Naming:

Renamed validateInput to ValidateYearInput to clearly indicate its purpose.
Code Efficiency:

Combined some of the validation logic in the Main method to streamline the process and avoid unnecessary checks.
Running the Program:
The user is prompted to enter a year.
The input is validated to ensure it is a valid integer within the range of 1 to 9999.
The program checks if the entered year is a leap year based on the correct rules and displays the result.
This updated version of your program is more accurate and efficient. If you have any more questions or need further assistance, feel free to ask!

    //////////////////////////////////////////////////////
     */

}

