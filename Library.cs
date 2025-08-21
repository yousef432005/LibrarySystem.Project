using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frist_Project
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBookCount = 0;
        private Book[] BorrowedBooks = new Book[50];
        private int currentBorrowedBookCount = 0;

        public void Display()
        {
            for(int i = 0; i < currentBookCount; i++) 
            {
                    Console.WriteLine(books[i]);
            }
        }

        public void Add(Book book)
        {
            if(currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added succesfully");
            }
            else
            {
                Console.WriteLine("Library is Full, can't add new books");
            }
        }

        public void Remove(Book book)
        {
           int index = Array.IndexOf(books, book);
           books[index] = null;
           currentBookCount--;
            Console.WriteLine("Book removed");
        }

        public void BorrowBook(Book book)
        {
            if (currentBookCount < BorrowedBooks.Length)
            {
                BorrowedBooks[currentBorrowedBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added succesfully");
            }
            else
            {
                Console.WriteLine("Sorry, can not borrow more books");
            }
        }

    }
}
