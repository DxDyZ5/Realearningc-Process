using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using STARTINGAGAIN;

namespace startingAgain
{ 
    class Program //POO EXERCISE 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library Management System!"); Library library = new();

            Member alice = new("1D01", "Alice");
            library.RegisterMember(alice);

            Member bob = new("1D02", "Bob");
            library.RegisterMember(bob);

            Book book1984 = new("1984", "George Orwell", "9781443434973");
            library.AddBook(book1984);

            Book bookToKill = new("To Kill a Mockingbird", "Harper Lee", "9780446310789"); 
            library.AddBook(bookToKill);


            alice.BorrowBook(book1984);
            bob.BorrowBook(book1984);
            bob.BorrowBook(bookToKill);

            library.DisplayAvailableBooks();
            library.DisplayBorrowedBooks();

            alice.returnBook(book1984);

            library.DisplayAvailableBooks();
            library.DisplayBorrowedBooks();



            /* Book Search Method (Bonus Challenge):
You can implement a SearchBook() method in the Library class that allows users to search for a book by title or author:

            public Book SearchBook(string query) 
            {
                 return booksAvailable.FirstOrDefault(book => book.Title.Contains(query, StringComparison.OrdinalIgnoreCase) || 
                                                  book.Author.Contains(query, StringComparison.OrdinalIgnoreCase));
            }
*/

        }
    }
}

        
   