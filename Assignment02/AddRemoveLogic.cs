using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class AddRemoveLogic
    {
        public void AddB(Librarian l,int bid,String bname)
        {
            l.AddBook(new Book() { BookId = bid, BookName = bname });
            Console.WriteLine("Book Added Successfully");
        }
        public void AddN(Librarian l, int nid, String nname)
        {
            l.AddNewsPaper(new Newspaper() { NewspaperId = nid, NewspaperName = nname });
            Console.WriteLine("Newspaper Added Successfully");
        }
    }
}
