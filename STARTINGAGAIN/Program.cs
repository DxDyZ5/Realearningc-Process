using System;
using System.Reflection.Metadata;

namespace startingAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            //Needy program variables.
            const int pin = 3410;
            double balance = 0;
            double amount;

            // A friendly greetings to our bank.
            Console.WriteLine(@"
 ________  ___  ___  ________          ________  _________  _____ ______          
|\   __  \|\  \|\  \|\   ___ \        |\   __  \|\___   ___\\   _ \  _   \        
\ \  \|\ /\ \  \\\  \ \  \_|\ \       \ \  \|\  \|___ \  \_\ \  \\\__\ \  \       
 \ \   __  \ \   __  \ \  \ \\ \       \ \   __  \   \ \  \ \ \  \\|__| \  \      
  \ \  \|\  \ \  \ \  \ \  \_\\ \       \ \  \ \  \   \ \  \ \ \  \    \ \  \     
   \ \_______\ \__\ \__\ \_______\       \ \__\ \__\   \ \__\ \ \__\    \ \__\    
    \|_______|\|__|\|__|\|_______|        \|__|\|__|    \|__|  \|__|     \|__|    
                                                                                  
                                                                                                                                                                
 ~ your favorite ATM nearby you.");

            // asking for the pin
            Console.Write("To proceed, please enter your pin: ");
            int prompt;


            //validating the input
            while (!int.TryParse(Console.ReadLine(), out prompt) | prompt <= 0)
            {
                Console.WriteLine("Please, enter a valid input");
                Console.Write("To proceed, please enter your pin: ");
            }


            //Checking if the prompt match the pin
            if (prompt == pin)
            {
                //Declaring a empty string variable for the do while. Keeping the loop until the user decide to move on.
                string continueon = string.Empty;

                do
                {
                    //principal menu
                    Console.WriteLine(@"
                       Welcome!
                    1. withdraw
                    2. deposit
                    3. check balance
");
                    Console.Write("Please, choose an option: ");
                    int option;

                    //validating if user input a option from the menu
                    while (!int.TryParse(Console.ReadLine(), out option) | option <= 0 | option > 3)
                    {
                        Console.WriteLine("Please, enter a valid input");
                        Console.Write("Please, choose an option from the menu: ");
                    }


                    //checking option with switch and therefore do the chosen action.
                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter an amount: ");
                            double.TryParse(Console.ReadLine(), out amount);

                            //checking if balance is different to zero or if balance is greater than the amount, for therefore withdraw.
                            if (balance > amount & amount > 0)
                            {
                                balance -= amount;
                            }
                            else
                            {
                                Console.WriteLine("There isn't enough balance");
                            }

                            break;
                        case 2:
                            Console.Write("Enter an amount: ");
                            double.TryParse(Console.ReadLine(), out amount);
                            if (amount > 0)
                            {
                                balance += amount;
                            }
                            else
                            {
                                Console.WriteLine("Value should be greater than zero");
                            }

                            break;
                        case 3:
                            Console.WriteLine($"Balance: {balance}");
                            break;
                        default:
                            break;
                    }
                    //asking whether want to continue or not. Reading the input and converting the input to lowerCase.
                    Console.Write("Do you want to continue (y/n): ");
                    continueon = Console.ReadLine().Trim().ToLower();


                }
                //represent a boolean statement with a string variable.
                while (continueon != "n");
            }
            else
            {
                Console.WriteLine("Pin doesn't match, try again.");
                //getting back if the ping doesn't match.
                Main(args);
            }
        }
    }
}
