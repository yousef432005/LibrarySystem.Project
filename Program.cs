using Frist_Project;
using System;
using System.Collections;

class program
{ 
    static void Main(string[] args)
    {
       
        Console.WriteLine("Welcome to the Library System");
        Library library = new Library();
        Console.WriteLine("Ara you Librarian or regular User (L/R)");

        char usertype = Console.ReadLine().ToUpper()[0];

        if(usertype == 'L')
        {
            Console.WriteLine("Welcome Librarian, Enter your name");
            string Librarian_Name = Console.ReadLine();

            Librarian librar1 = new Librarian(Librarian_Name);
            Console.WriteLine($"Welcome {librar1.Name}");

            while (true)
            {
                Console.WriteLine("Please choose to Add book (A) / Remove book (R) / Display books (D)");
                char choice = Console.ReadLine().ToUpper()[0];
                switch (choice)
                {
                    case 'A':
                        Console.WriteLine("Enter book details");
                        string BookTitle = Console.ReadLine();
                        string BooKAuth = Console.ReadLine();
                        int BookYear = int.Parse(Console.ReadLine());
                        Book book = new Book()
                        {
                            Title = BookTitle,
                            Author = BooKAuth,
                            Year = BookYear,
                        };
                        librar1.Add(book, library);
                        break;

                    case 'R':
                        Console.WriteLine("Enter book details to remove");
                        BookTitle = Console.ReadLine();
                        BooKAuth = Console.ReadLine();
                        BookYear = int.Parse(Console.ReadLine());
                        book = new Book()
                        {
                            Title = BookTitle,
                            Author = BooKAuth,
                            Year = BookYear,
                        };
                        librar1.Remove(book, library);
                        break;

                    case 'D':
                        Console.WriteLine("The book list :");
                        librar1.DisplayBooks(library);
                        break;

                    default:

                        Environment.Exit(0);
                        break;



                }
            }
        }
        else if(usertype == 'R')
        {
            Console.WriteLine("Welcome sir, Enter your name");
            string username = Console.ReadLine();

            LibraryUser user = new LibraryUser(username);

            Console.WriteLine($"Welcome {user.Name}");

            while (true)
            {
                Console.WriteLine("Please choose to Display books (D) or Borrow Book (B)");
                char choice = Console.ReadLine().ToUpper()[0];
                switch (choice)
                {
                    case 'D':
                        Console.WriteLine("The book list :");
                        user.DisplayBooks(library);
                        break;

                    case 'B':
                        Console.WriteLine("Enter book details to borrow");
                        string BookTitle = Console.ReadLine();
                        string BooKAuth = Console.ReadLine();
                        int BookYear = int.Parse(Console.ReadLine());
                        Book book = new Book()
                        {
                            Title = BookTitle,
                            Author = BooKAuth,
                            Year = BookYear,
                        };
                        user.BorrowBook(book,library);
                        break;

                    default:

                        Environment.Exit(0);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Plearse enter correct value (L/R)");
        }




        





    }
}
 






