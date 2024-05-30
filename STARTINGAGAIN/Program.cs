//Assigning value if it's valid with the line: - double.TryParse(Console.ReadLine(), out length - 

//Logic behind the!(negating this statement: double.TryParse(Console.ReadLine(), out length) If the tryparse is successful, then it will give true.By using

/*
 Logic behind the ! (negating this statement: double.TryParse(Console.ReadLine(), out length) 
    If the TryParse is successful, then it will be true. By using !, we are stoping the loop by negating the statement,we declare the value false. So value is successful for our program.
    In the other hand if the value it is not successful it will be false. We don't want that, because it will stop the loop when the value hasn't been assigned. by negating the statement,we declare the value true. Letting the loop continue.
    In this case if what we explained before happen, it won't stop the loop because we have another logic nested into the while statement: | length <= 0.
    the operator | (or) help to give logic of even though the left hand stament is false, the right hand stament still true, so the 'while' still running.
    the difference between || (or) and | (or):

    The conditional logical OR operator || also computes the logical OR of its operands, but doesn't evaluate the right-hand operand if the left-hand operand evaluates to true.
according to this, if the right hand statement is true the other won't be evaluate or include it. 
 */


using System;

namespace  startingAgain 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greetings 
            Console.WriteLine("Welcome. This a program to calculate the area of a rectangule");

            // Asking for the lenght value 
            Console.Write("Please, enter the length of the rectangule: ");
            double length;

            //validating the input of length
            while (!double.TryParse(Console.ReadLine(), out length) | length <= 0)
            {

                Console.WriteLine("Invalid input (value should be either positive or more than zero)");
                Console.Write("Please, enter the length of the rentangule: ");
            }

            //width value
            Console.Write("Please, enter the width of the rentangule: ");
            double width;

            //validating the input of width 
            while (!double.TryParse(Console.ReadLine(), out width) | width <= 0)
            {


                Console.WriteLine("Invalid input (value should be either positive or more than zero)");
                Console.Write("Please, enter the width of the rentangule: ");
            }
            //formula: area of rectangule
            double area = width * length;

            //result
            Console.WriteLine($"The area of rectangule given the width and length it's: {area}");

        }
    }
}
