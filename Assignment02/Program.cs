using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
namespace Assignment02
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Librarian l1 = new CrudOperationOnBook();
            Librarian l2 = new CrudOperationOnNewspaper();
            CrudOperationOnBook bl = new CrudOperationOnBook();
            CrudOperationOnNewspaper nl = new CrudOperationOnNewspaper();
            Borrower newb = new Borrower();
            while (true)
            {

                Console.WriteLine(":::Library Management System:::\n");
                Console.WriteLine("\n1. Librarian" +
                    "\n2. Borrower" +
                    "\n3. Exit");


                int loginc = Convert.ToInt32(Console.ReadLine());
                if (loginc == 1)
                {
                    AddRemoveLogic ad = new AddRemoveLogic();
                    
                    while (true)
                    {
                        Console.WriteLine("\n::: Librarian :::" +
                        "\n1. Add New Books/Newspaper" +
                        "\n2. Remove Exsisting Books/NewsPaper" +
                        "\n3. See All Available Books" +
                        "\n4. Logout");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        if(ch == 1)//Add 
                        {
                            while (true)
                            {
                                Console.WriteLine("1: Add a Book\n" +
                                    "2: Add a NewsPaper\n" +
                                    "3: Go Back");
                                int nb = Convert.ToInt32(Console.ReadLine());

                                if (nb == 1) //Adding Book
                                {
                                    while (true)
                                    {
                                        Console.Write("\n::Add Book::\nPlease Enter New Booking ID: ");
                                        int a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Please Enter New Book Name: ");
                                        string b = Console.ReadLine();
                                        ad.AddB(bl, a, b);
                                        //l1.AddBook(new Book() { BookId = a, BookName = b });
                                        //ad.AddB(l1, a, b);
                                        //l1.AddBook(new Book() { BookId = a, BookName = b });
                                        //Console.WriteLine("::Book Added Successfully::\n");
                                        Console.WriteLine("\nPress 1 To Add Another Book  \nPress 2 To Exit");
                                        int abch = Convert.ToInt32(Console.ReadLine());
                                        if (abch == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Program.viewbook(bl);
                                            Console.WriteLine("\nExiting Add Portal\n");
                                            break;
                                        }

                                    }
                                }


                                else if (nb == 2)//Add Newspaper
                                {
                                    while (true)
                                    {
                                        Console.Write("\n::Add NewsPaper::\nPlease Enter New Newspaper ID: ");
                                        int a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Please Enter New Newspaper Name: ");
                                        string b = Console.ReadLine();
                                        ad.AddN(nl,a,b);
                                        //nl.GetNewspaper(new Newspaper() { NewspaperId = a, NewspaperName = b });
                                        //ad.AddN(, a, b);
                                        Console.WriteLine("\nPress 1 To Add Another Newspaper  \nPress 2 To Exit");
                                        int abch = Convert.ToInt32(Console.ReadLine());
                                        if (abch == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Program.viewnewspaper(nl);
                                            Console.WriteLine("\nExiting Add Portal\n");
                                            break;
                                        }

                                    }


                                }
                                else
                                {
                                    break;
                                }
                                //break;
                            }
                            
                        }
                        else if (ch == 2)//Remove 
                        {
                            while (true)
                            {
                                
                                Console.WriteLine("\n:::Remove:::\n" +
                                    "1: Remove a Book\n" +
                                    "2: Remove a NewsPaper\n" +
                                    "3: Go Back");
                                int nb = Convert.ToInt32(Console.ReadLine());
                                if(nb == 1)
                                {
                                    Console.Write("\n:::::Remove Book:::::\n ");
                                    while (true)
                                    {
                                        Console.Write("Please Enter New Booking Name Or ID: ");
                                        string rbook = Console.ReadLine();
                                        Book findbook = bl[rbook, rbook];
                                        bl.Remove(findbook);


                                        Console.WriteLine("::Book Removed Successfully::\n");
                                        Console.WriteLine("\nPress 1 To Remove Another Book  \nPress 2 To Exit");
                                        int abch = Convert.ToInt32(Console.ReadLine());
                                        if (abch == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n::: Exsisting Books ::: \n");
                                            foreach (Book c in bl)
                                            {
                                                Console.WriteLine($"Book ID - {c.BookId}\tBook Name - {c.BookName}");
                                            }
                                            Console.WriteLine("\nExiting Book Removing Portal\n");
                                            break;
                                        }

                                    }
                                }
                                else if (nb == 2)
                                {
                                    Console.Write("\n:::::Remove NewsPaper:::::\n ");
                                    while (true)
                                    {
                                        Console.Write("Please Enter New NewsPaper Name Or ID: ");
                                        string rnewspaper = Console.ReadLine();
                                        Newspaper findnewspaper = nl[rnewspaper, rnewspaper];
                                        nl.Remove(findnewspaper);
                                        Console.WriteLine("::Newspaper Removed Successfully::\n");
                                        Console.WriteLine("\nPress 1 To Remove Another Newspaper  \nPress 2 To Exit");
                                        int abch = Convert.ToInt32(Console.ReadLine());
                                        if (abch == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n::: Exsisting Newspaper ::: \n");
                                            foreach (Newspaper c in nl)
                                            {
                                                Console.WriteLine($"Newspaper ID - {c.NewspaperId}\t" +
                                                    $"Newspaper Name - {c.NewspaperName}");
                                            }
                                            Console.WriteLine("\nExiting Newspaper Removing Portal\n");
                                            break;
                                        }

                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                           
                        }
                        else if (ch ==3)//View
                        {
                            while (true)
                            {

                                Console.WriteLine("\n::: View :::" +
                                    "\n1: Available Books" +
                                    "\n2: Available Newspaper" +
                                    "\n3: Go Back");
                                int nh = Convert.ToInt32(Console.ReadLine());
                                if(nh== 1)
                                {
                                    Program.viewbook(bl);
                                }
                                else if (nh == 2)
                                {
                                    Program.viewnewspaper(nl);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            
                            
                            Console.WriteLine("\nExiting Book Viewing Portal\n");
                        }
                        else
                        {
                            Console.WriteLine("Logging Out\n");
                            Thread.Sleep(3000);
                            Console.WriteLine("Successfully Logged Out");
                            break;
                        }
                    }
                    //break;
                }
                else if (loginc == 2)
                {
                    AddRemoveLogic addbo = new AddRemoveLogic();
                    Console.Write(":::LogIn:::\nEnter Your Name: ");
                    string Bname = Console.ReadLine();
                    Console.Write("Enter Your Id: ");
                    string id = Console.ReadLine();
                    if (Program.ValidateName(Bname) && Program.ValidateID(id))
                    {
                        int ID = Convert.ToInt32(id);
                        addbo.AddNewBorrower(newb, ID, Bname);
                        while (true)
                        {
                            
                            
                            Console.WriteLine($"\n::::Welcome TO MyLIbrary::::\n::::Login Id {ID}::::\n" +                              
                                $"\n1: Search For Your Book" +
                                $"\n2: Search For Your Newspaper" +
                                $"\n3: Check for all Available Books & Newspaper" +
                                $"\n4: Return Book" +
                                $"\n5: Exit");
                            
                            int nb = Convert.ToInt32(Console.ReadLine());
                            if (nb == 1)
                            {
                                Console.WriteLine("\n::::Books in Stock::::");
                                Program.viewbook(bl);
                                Console.WriteLine("\n::::NewsPapers in Stock::::");
                                Program.viewnewspaper(nl);
                                while (true) 
                                {
                                    Console.WriteLine("\n1. To Issue Book\n2. To Issue Newspaper \n3. To Go Back");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    if (a == 1)
                                    {
                                        Console.WriteLine("\nWhich Book You Want Borrow??\nPlease mention It's ID or Name: ");
                                        string Bookname = Console.ReadLine();
                                        Book findbook = bl[Bookname, Bookname];
                                        newb.AddBorrowerBook(findbook, Bname, ID, bl);
                                        foreach (BookBorrowed b in newb)
                                        {
                                            Console.WriteLine($"\n:::::Book Issued:::::\nBook Name - {b.BookName} Issued To {b.BorrowedName}");
                                        }
                                    }
                                    else if (a == 2)
                                    {

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                
                            }
                            else if(nb == 2)
                            {

                            }
                            else if (nb == 3)
                            {
                                while (true)
                                {
                                    Console.WriteLine(":::View:::" +
                                        "\n1. View All Available Book" +
                                        "\n2. View All Available Newspaper" +
                                        "\n3. To Exit");
                                    int ch = Convert.ToInt32(Console.ReadLine());
                                    if (ch == 1)
                                    {
                                        Program.viewbook(bl);
                                    }
                                    else if (ch == 2)
                                    {
                                        Program.viewnewspaper(nl);
                                    }
                                    else { break; }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {

                        Console.WriteLine("TryAgain\n");
                    }
                }
                else
                {
                    break;
                }
               // break;
            }

            
        }
        static public void viewbook(object o)
        {
            CrudOperationOnBook bl = (CrudOperationOnBook)o;
            Console.WriteLine("\n::Books Available Are as Follows::\n");
            foreach (Book c in bl)
            {
                Console.WriteLine($"Book ID - {c.BookId}\tBook Name - {c.BookName}");
            }
        }
        static public void viewnewspaper(object o)
        {
            CrudOperationOnNewspaper nl = (CrudOperationOnNewspaper)o;
            Console.WriteLine("\n::Newspapers Available Are as Follows::\n");
            foreach (Newspaper c in nl)
            {
                Console.WriteLine($"NewsPaper ID - {c.NewspaperId}\tNewspaper Name - {c.NewspaperName}");
            }
        }
        static public bool ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$") && name != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error: Entered Name Should Only Contain Alphabets!!!");
                return false;
            }
        }
        static public bool ValidateID(string id)
        {
            if (Regex.IsMatch(id, @"^[0-9]+$") && id != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error: Entered Id Should Only Contain Digits Only!!!");
                return false;
            }
        }
    }
    
}
