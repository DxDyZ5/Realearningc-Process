/*
 IMPROVEMENTS FROM CHATGPT:


using System;
using System.Collections.Generic;

namespace startingAgain
{
    class Program
    {
        static List<int> fibonacciList = new List<int> {0, 1}; // Initialize with the first two terms
        static int numTerm;
        
        static void Main(string[] args)
        {
            ValidateTerm();
            
            if (numTerm == 1)
            {
                // If only one term is requested, print the first term and return
                Console.WriteLine(fibonacciList[0]);
                return;
            }
            else if (numTerm == 2)
            {
                // If two terms are requested, print both initial terms and return
                Console.WriteLine(fibonacciList[0]);
                Console.WriteLine(fibonacciList[1]);
                return;
            }

            // Calculate Fibonacci sequence for terms > 2
            int firstValue = fibonacciList[0];
            int secondValue = fibonacciList[1];

            while (fibonacciList.Count < numTerm)
            {
                int nextValue = firstValue + secondValue;
                fibonacciList.Add(nextValue);

                // Update the first and second values for the next iteration
                firstValue = secondValue;
                secondValue = nextValue;
            }

            // Print the Fibonacci sequence
            foreach (int value in fibonacciList)
            {
                Console.WriteLine(value);
            }
        }

        static void ValidateTerm()
        {
            Console.Write("Please enter the number of terms for the Fibonacci sequence: ");
            while (!int.TryParse(Console.ReadLine(), out numTerm) || numTerm <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                Console.Write("Please enter the number of terms for the Fibonacci sequence: ");
            }
        }
    }
}


 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace startingAgain
{
    class Program
    {
        static List<int> fibonacciList = new List<int> {0, 1};
        static int numTerm;
        static void Main(string[] args)
        {
            validatingTerm();
            int firstValue = fibonacciList[0], secondValue = fibonacciList[1];

            while (fibonacciList.Count != numTerm)
            {
                int sumFibnonnaci =  firstValue + secondValue;

                fibonacciList.Add(sumFibnonnaci);

                firstValue = fibonacciList[^2]; //get the number prevoius last. New feature introduced in C#8

                secondValue = fibonacciList[^1];  //get the last number
            }

            foreach (short i in fibonacciList)
            {
                Console.WriteLine(i);
            }
        }

        static void validatingTerm()
        {
            Console.Write("Please enter the term number for the fibonnaci sequence: ");
            while (!int.TryParse(Console.ReadLine(), out numTerm) || numTerm <= 0)
            {
                Console.WriteLine("Invalid term. Try with a positive term.");
                Console.Write("Please enter the term number for the fibonnaci sequence: ");
            }

        }
    }
}
