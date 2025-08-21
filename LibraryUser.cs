using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frist_Project
{
    internal class LibraryUser : User
    {
        public LibraryCard Card {  get; set; }

        public LibraryUser(string name)
        {
            name = Name;
        }

        public void BorrowBook(Book book, Library library)
        {
            library.BorrowBook(book);
        }

    }
}
