using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class AddRemoveLogic
    {
        public void AddNew(object d,int i,string b)
        {
            if(d is CrudOperationOnBook)
            {
                CrudOperationOnBook cd= d as CrudOperationOnBook;
                cd.AddBook(new Book() { BookId = i, BookName = b });
                Console.WriteLine("Book Added Successfully");
            }
            else if(d is CrudOperationOnNewspaper)
            {
                CrudOperationOnNewspaper cd = d as CrudOperationOnNewspaper;
                cd.AddNewspaper(new Newspaper() { NewspaperId = i, NewspaperName = b });
                Console.WriteLine("Newspaper Added Successfully");
            }
            else if(d is Borrower)
            {
                Borrower nb = d as Borrower;
                nb.AddBorrower(new BorrowerList() { BorrowerId = i, BorrowerName = b });
                Console.WriteLine($"\nHi! {b} Which Book You Will Prefer Today");
            }
        }
       
        
    }
}
