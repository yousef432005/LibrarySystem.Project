using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frist_Project
{
    internal class Librarian : User
    {
        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void Add(Book newBook, Library library) 
        {
            library.Add(newBook);
        }

        public void Remove(Book newBook, Library library)
        {
            library.Remove(newBook);
        }

    }
}
