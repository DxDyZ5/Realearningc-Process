using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace STARTINGAGAIN
{
    public class Member 
    {
        private string _memberID { get; set; }
            
       private string _name { get; set; } = string.Empty;
        
        List<Book> _books  = new List<Book> { };

        public Member(string memberID, string name) {
            _memberID = memberID;
            _name = name;
        }
 

        public string MemberID => _memberID;
        public string Name => _name;
        public List<Book> Books => _books;

        public void BorrowBook(Book book)
        {
            //VALIDATION WHETHER BOOK IS EMPTY OR NOT
            /* if (book == null)
            {
                Console.WriteLine("Invalid book. Book does not exist.");
                return;
            }*/
            if (book.BookState == false)
            {
                Console.WriteLine("Book already borrowed by another member.");
                return;
            }
            else
            {
                 book.Borrow();
                _books.Add(book);
                Console.WriteLine("Book successfully borrowed");
            }
               

        }

        public  void returnBook(Book book)
        {
            //VALIDATION WHETHER BOOK IS EMPTY OR NOT
            /* if (book == null)
            {
                Console.WriteLine("Invalid book. Book does not exist.");
                return;
            }*/
            if (book.BookState == true)
            {
                Console.WriteLine("Book doesn't belong to this library...");
            }
            else
            {
                 book.Return();
                _books.Remove(book);
                Console.WriteLine("Book successfully returned");
            }
           
        }
        
        public override string ToString()
        {
            return @$"Member ID: {MemberID}  User: {Name} 
                   Books borrowed: {BooksBorrowedList}" ;
        }


        private void BooksBorrowedList()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"Title: {book.Title} - Author: {book.Author} - ISBN: {book.ISBN}");
            }
        }

    }
}
