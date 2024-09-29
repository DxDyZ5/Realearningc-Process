using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace STARTINGAGAIN
{
    public class Book
    {
        private string _title { get; set; }
        private string _author { get; set; }
        private string _ISBN { get; set; }
        private bool _bookState { get; set; } = true;


        public string Title => _title;
        public string Author => _author;
        public string ISBN => _ISBN;
        public bool BookState => _bookState;
  

        public Book(string title, string author, string ISBN, bool bookState = true)
        {
            _title = title;
            _author = author;
            _ISBN = ISBN;
            _bookState = bookState;
        }

        public void Borrow()
        {
            _bookState = false;
        }

        public void Return()
        {
            _bookState = true;
        }


        public override string ToString()
        {
            return @$"Book information
                     Title: {Title}
                     Author: {Author}
                     ISBN code: {ISBN}";
        }


        /*
          DATA VALIDATION:
         
         public Book(string title, string author, string ISBN, bool bookState = true)
        {
            // Data validation
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("Author cannot be empty.");
            }

            if (!IsValidISBN(ISBN))
            {
                throw new ArgumentException("Invalid ISBN format.");
            }

            _title = title;
            _author = author;
            _ISBN = ISBN;
            _bookState = bookState;
        }

        // Helper method to check ISBN format (basic check)
        private bool IsValidISBN(string isbn)
        {
            // Assuming ISBN is valid if it's 10 or 13 characters long (for simplicity)
            return isbn.Length == 10 || isbn.Length == 13;
        }
         */
    }
}
