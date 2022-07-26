using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class AddRemoveLogic
    {
        public void AddB(CrudOperationOnBook b,int bid,String bname)
        {
            
            b.AddBook(new Book() { BookId = bid, BookName = bname });
            Console.WriteLine("Book Added Successfully");
        }
        public void AddN(CrudOperationOnNewspaper n, int nid, String nname)
        {
            n.AddNewspaper(new Newspaper() { NewspaperId = nid, NewspaperName = nname });
            Console.WriteLine("Newspaper Added Successfully");
        }
    }
}
