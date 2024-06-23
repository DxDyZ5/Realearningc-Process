/*
  Improvements from chatgpt
 using System;

namespace startingAgain
{
 class Program
 {
     const int pin = 3410;
     static double balance = 0;

     static void Main(string[] args)
     {
         Console.WriteLine(@"
________  ___  ___  ________          ________  _________  _____ ______          
|\   __  \|\  \|\  \|\   ___ \        |\   __  \|\___   ___\\   _ \  _   \        
\ \  \|\ /\ \  \\\  \ \  \_|\ \       \ \  \|\  \|___ \  \_\ \  \\\__\ \  \       
\ \   __  \ \   __  \ \  \ \\ \       \ \   __  \   \ \  \ \ \  \\|__| \  \      
\ \  \|\  \ \  \ \  \ \  \_\\ \       \ \  \ \  \   \ \  \ \ \  \    \ \  \     
\ \_______\ \__\ \__\ \_______\       \ \__\ \__\   \ \__\ \ \__\    \ \__\    
 \|_______|\|__|\|__|\|_______|        \|__|\|__|    \|__|  \|__|     \|__|    

~ your favorite ATM nearby you.");

         PromptForPin();
     }

     static void PromptForPin()
     {
         int attempts = 0;
         const int maxAttempts = 3;
         while (attempts < maxAttempts)
         {
             Console.Write("To proceed, please enter your pin: ");
             if (int.TryParse(Console.ReadLine(), out int enteredPin) && enteredPin == pin)
             {
                 ShowMenu();
                 return;
             }
             else
             {
                 attempts++;
                 Console.WriteLine("Incorrect PIN. Please try again.");
             }
         }
         Console.WriteLine("Too many incorrect attempts. Exiting.");
     }

     static void ShowMenu()
     {
         string continueOn;
         do
         {
             Console.WriteLine(@"
                    Welcome!
                 1. Withdraw
                 2. Deposit
                 3. Check Balance
             ");
             Console.Write("Please, choose an option: ");
             int option;
             while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
             {
                 Console.WriteLine("Invalid input. Please choose a valid option.");
                 Console.Write("Please, choose an option: ");
             }

             switch (option)
             {
                 case 1:
                     Withdraw();
                     break;
                 case 2:
                     Deposit();
                     break;
                 case 3:
                     CheckBalance();
                     break;
             }

             Console.Write("Do you want to continue (y/n): ");
             continueOn = Console.ReadLine().Trim().ToLower();
         }
         while (continueOn != "n");
     }

     static void Withdraw()
     {
         Console.Write("Enter an amount to withdraw: ");
         if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
         {
             if (balance >= amount)
             {
                 balance -= amount;
                 Console.WriteLine($"Withdrawal successful. New balance: {balance}");
             }
             else
             {
                 Console.WriteLine("Insufficient balance.");
             }
         }
         else
         {
             Console.WriteLine("Invalid amount. Please enter a positive number.");
         }
     }

     static void Deposit()
     {
         Console.Write("Enter an amount to deposit: ");
         if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
         {
             balance += amount;
             Console.WriteLine($"Deposit successful. New balance: {balance}");
         }
         else
         {
             Console.WriteLine("Invalid amount. Please enter a positive number.");
         }
     }

     static void CheckBalance()
     {
         Console.WriteLine($"Your current balance is: {balance}");
     }
 }
}



comments:

Explanation of Changes:
Refactored Code:

Created separate methods for PromptForPin, ShowMenu, Withdraw, Deposit, and CheckBalance to make the code more modular and easier to read.
PromptForPin method now handles the PIN verification with a maximum of 3 attempts before exiting.
Improved Input Validation:

Enhanced the validation logic for both PIN entry and menu options to ensure valid inputs.
Logical Operators:

Used && for logical AND and || for logical OR to ensure proper logical operations.
Loop for PIN Attempts:

Added a loop in PromptForPin to allow the user to enter the PIN up to three times before exiting.
Balance Operations:

Validated the amounts for deposit and withdrawal to ensure they are positive and handled edge cases such as insufficient balance for withdrawals.
User Feedback:

Provided feedback messages for successful and failed operations to enhance user experience.
This improved version ensures better structure, readability, and robustness in handling user input and ATM operations.

  */

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
