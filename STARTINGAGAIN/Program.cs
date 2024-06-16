using System;

namespace  startingAgain 
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = "Sophia Johnson";


            string[] course = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};


            int[] grade = { 4, 3, 3, 3, 4};

            int[] creditHours = { 3, 3,4, 4, 3};



            Console.WriteLine($"Student: {student} \nCourse: \t\t\t Grade: \t\t\tCredit Hours:\n{course[0]}\t\t         {grade[0]}\t\t\t\t {creditHours[0]}\n{course[1]}\t\t         {grade[1]}\t\t\t\t {creditHours[1]}\n{course[2]}\t\t         {grade[2]}\t\t\t\t {creditHours[2]}\n{course[3]}\t         {grade[3]}\t\t\t\t {creditHours[3]}\n{course[4]}\t\t         {grade[4]}\t\t\t\t {creditHours[4]}");


            int sumOfValuesOfDividend =  (grade[0] * creditHours[0]) + (grade[1] * creditHours[1]) + (grade[2] * creditHours[2]) + (grade[3] * creditHours[3]) + (grade[4] * creditHours[4]);

            int sumOfValuesOfDivisor = creditHours[0] + creditHours[1] + creditHours[2] + creditHours[3] + creditHours[4];


            decimal GPA = (decimal) sumOfValuesOfDividend / sumOfValuesOfDivisor;

            Console.WriteLine($"\nFinal GPA:\t\t {GPA.ToString("0.00")}");
        }
    }
}
