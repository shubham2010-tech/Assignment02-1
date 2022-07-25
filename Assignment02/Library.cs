using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Library 
    {
        public List<Book> _books;
        public List<Newspaper> _newspapers;
        private List<Borrower> borrowers;

    }

    internal class Borrower
    {
    }

    internal class Book:Library
    {

        public int BookId { get; set; }
        public string BookName { get; set; }

    }
    internal class Newspaper:Library
    {
        public int NewspaperId { get; set; }
        public string NewspaperName { get; set; }
    }
}
