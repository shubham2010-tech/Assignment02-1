using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(":::LIbrary Management System:::\n");
                Console.WriteLine("\n1. Librarian" +
                    "\n2. Borrower" +
                    "\n3. LogOut");
                Librarian l1 = new Librarian();
                
                //Pre Added Books
                l1.AddBook(new Book() { BookId = 1, BookName = "Avenger Secret War" });
                l1.AddBook(new Book() { BookId = 2, BookName = "Black Adam" });
                l1.AddBook(new Book() { BookId = 3, BookName = "Shazam" });
                l1.AddBook(new Book() { BookId = 4, BookName = "GOT" });
                l1.AddBook(new Book() { BookId = 5, BookName = "IronHeart" });
                l1.AddBook(new Book() { BookId = 6, BookName = "D." });
                l1.AddBook(new Book() { BookId = 7, BookName = "Death Note" });
                l1.AddBook(new Book() { BookId = 8, BookName = "World War" });
                l1.AddBook(new Book() { BookId = 9, BookName = "C#" });
                l1.AddBook(new Book() { BookId = 10, BookName = "New Life" });


                //Pre Added Newspapers
                l1.AddNewsPaper(new Newspaper() { NewspaperId = 1, NewspaperName = "HindustanTimes" });
                l1.AddNewsPaper(new Newspaper() { NewspaperId = 2, NewspaperName = "Global Times" });
                l1.AddNewsPaper(new Newspaper() { NewspaperId = 3, NewspaperName = "Times of India" });
                l1.AddNewsPaper(new Newspaper() { NewspaperId = 4, NewspaperName = "Dainik Jagaran" });
                l1.AddNewsPaper(new Newspaper() { NewspaperId = 5, NewspaperName = "IndianTimes" });


                int loginc = Convert.ToInt32(Console.ReadLine());
                if (loginc == 1)
                {
                    AddRemoveLogic ad = new AddRemoveLogic();
                    while (true)
                    {
                        Console.WriteLine("::: Librarian :::" +
                        "\n1.Add New Books/Newspaper" +
                        "\n2.Remove Exsisting Books/NewsPaper" +
                        "\n3.See All Available Books" +
                        "\n4.Logout");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        if(ch == 1)//Add Book
                        {
                            while (true)
                            {
                                Console.WriteLine("1: Add a Book\n" +
                                    "2:Add a NewsPaper\n" +
                                    "3:Go Back");
                                int nb = Convert.ToInt32(Console.ReadLine());
                                if (nb == 1)
                                {
                                    while (true)
                                    {
                                        Console.Write("\n::Add Book::\nPlease Enter New Booking ID: ");
                                        int a = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Please Enter New Book Name: ");
                                        string b = Console.ReadLine();
                                        ad.AddB(l1, a, b);
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
                                            Console.WriteLine("::: Last Index Books got Added ::: \n");
                                            foreach (Book c in l1)
                                            {
                                                Console.WriteLine($"Book ID - {c.BookId}\tBook Name - {c.BookName}");
                                            }
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
                                        ad.AddN(l1, a, b);
                                        Console.WriteLine("\nPress 1 To Add Another Newspaper  \nPress 2 To Exit");
                                        int abch = Convert.ToInt32(Console.ReadLine());
                                        if (abch == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("::: Last Index Newspapers got Added ::: \n");
                                            foreach (Newspaper np in l1)
                                            {
                                                Console.WriteLine($"Newspaper ID - {np.NewspaperId}\t" +
                                                    $"Newspaper Name - {np.NewspaperName}");
                                            }
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
                        else if (ch == 2)//Remove Book
                        {
                            Console.Write("\n:::::Remove Book:::::\n ");
                            while (true)
                            {
                                Console.Write("Please Enter New Booking Name Or ID: ");
                                string rbook = Console.ReadLine();
                                Book findbook = l1[rbook,rbook];
                                l1.RemoveBook(findbook);
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
                                    foreach (Book c in l1)
                                    {
                                        Console.WriteLine($"Book ID - {c.BookId}\tBook Name - {c.BookName}");
                                    }
                                    Console.WriteLine("\nExiting Book Removing Portal\n");
                                    break;
                                }

                            }
                        }
                        else if (ch ==3)
                        {
                            Console.WriteLine("\n::Books Available Are as Follows::\n");
                            foreach (Book c in l1)
                            {
                                Console.WriteLine($"Book ID - {c.BookId}\tBook Name - {c.BookName}");
                            }
                            
                            Console.WriteLine("\nExiting Book Viewing Portal\n");
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (loginc == 2)
                {

                }
                else
                {
                    break;
                }
                break;
            }

            
        }
        
    }
}
