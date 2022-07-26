using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Library :IEnumerable
    {
        protected List<Book> _books;
        protected List<Newspaper> _newspapers;
        
        protected List<NewspaperBorrowed> _NewspaperBorroweds;
        protected List<BookBorrowed> _bookBorroweds;
        public void AddBorrowerBook(Book newbook, string Name, int BOId,CrudOperationOnBook b)
        {
            BookBorrowed newb = new BookBorrowed()
            {
                BookID = newbook.BookId,
                BookName = newbook.BookName,
                BorrowedId = BOId
            ,
                BorrowedName = Name
            };
            
            if (_bookBorroweds == null)
            {
                _bookBorroweds = new List<BookBorrowed>();
            }
            _bookBorroweds.Add(newb);
            Book db = b[Name, Name];
            b.Remove(db);
        }
        public IEnumerator GetEnumerator()
        {
            if (_bookBorroweds != null)
            {
                foreach (BookBorrowed AvailablB in _bookBorroweds)
                {
                    yield return AvailablB;
                }
            }

            else
            {
                yield break;
            }
        }
    }

    

    class Book
    {

        public int BookId { get; set; }
        public string BookName { get; set; }


    }
    class Newspaper
    {
        public int NewspaperId { get; set; }
        public string NewspaperName { get; set; }

    }
    class BookBorrowed
    {
        public int BorrowedId { get; set; }
        public string BorrowedName { get; set; }
        public int BookID { get; set; }
        public string BookName {get;set;}

        

    }
    class NewspaperBorrowed
    {
        public int BorrowedId { get; set; }
        public string BorrowedName { get; set; }
        public int NewsPaperID { get; set; }
        public string NewsPaperName { get; set; }
    }
}
