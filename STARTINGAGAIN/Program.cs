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
            validateInput();

           while (!(year > DateTime.MinValue.Year && year < DateTime.MaxValue.Year))
           {
                Console.WriteLine("Year is not valid. Try with any value greater than 0 and less than 9999");
                validateInput();
           }
           IsLeapYearOrnot(year);
        }
            
       
        
        static void validateInput() {
            
            Console.Write("Please, enter a year: ");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("No valid input. Try again");
                Console.Write("Please, enter a year: ");
            }
        }

        static void IsLeapYearOrnot(int year)
        {
            Console.WriteLine(year % 4 == 0 ? $"The year {year} is leap" : $"The year {year} is not leap");
        }
    }     
    
}    

