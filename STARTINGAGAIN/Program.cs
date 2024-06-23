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
