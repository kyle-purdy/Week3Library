using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        // title property to the title field
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set 
            {
                // Checks if any characters in the author name are digits
                if(!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain digits.");
                }
            }
        } public string Isbn
        {
            get { return isbn; }
            set 
            {
                // Checks if ISBN is not blank]
                if(value!= "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }


        // Constructor to initialize the Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }


        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine();
        }
    }
}


