using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    abstract class Library 
    {
        protected List<Book> _books;
        protected List<Newspaper> _newspapers;
        
        protected List<NewspaperBorrowed> _NewspaperBorroweds;
        protected List<BookBorrowed> _bookBorroweds;

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
