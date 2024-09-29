using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARTINGAGAIN
{
    public class Library 
    {
        List<Book> booksAvailable = new List<Book>();

        List<Member> membersRegistered = new List<Member>();

        public Library() { }


        public void AddBook(Book book) {

            if (booksAvailable.Contains(book))
                Console.WriteLine("Book already added");
            else booksAvailable.Add(book);  
        }

        public void RegisterMember(Member member) {
            if (membersRegistered.Contains(member))
                Console.WriteLine("Member already registered");
            else membersRegistered.Add(member);
        }

        public void DisplayAvailableBooks() {
    
            if (booksAvailable.Count > 0)
            {
                Console.WriteLine("Current available books: ");
                foreach (Book book in booksAvailable)
                {
                    if (book.BookState.Equals(true)) //value for default is true no need of true again
                        Console.WriteLine($"{book.Title} by {book.Author}");         
                }          
            }

            /* improvement:
             
            if (!booksAvailable.Any(book => book.BookState)) 
            {
                Console.WriteLine("No available books at the moment.");
                return;  // Exit the method if no books are available
            }


    if (booksAvailable.Count > 0)
        {
            Console.WriteLine("Current available books: ");
            foreach (Book book in booksAvailable)
        {
            if (book.BookState) 
                Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
             */

        }

        public void DisplayBorrowedBooks() {
            if (booksAvailable.Count > 0)
            {
                Console.WriteLine("Current borrowed books: ");
                {
                    foreach (Member member in membersRegistered)
                    {
                        var title = from T in member.Books select T.Title; /*ONE LINE CODE*/ var author = from A in member.Books select A.Author;                
                        if (title.Any() == true && author.Any() == true)
                           Console.WriteLine($"{title.First()} by {author.First()} - borrowed by: {member.Name}");

                        /*I was trying to access to the single data 'title' and 'author' through QUERY instead of the simple iterate forEach
                withing the member.books list...
                        */
                    }
                }


               

                /*
                 

                 CHATGPT improvements in optimization and simplicity:
                public void DisplayBorrowedBooks()
                {
                    foreach (Member member in membersRegistered)
                    {
                        if (member.Books.Any())
                        {
                            Console.WriteLine($"Books borrowed by {member.Name}:");
                            foreach (Book book in member.Books)
                            {
                                Console.WriteLine($"{book.Title} by {book.Author}");
                            }
                        }
                    }
                }
                 */
            }
        }

    }
}
