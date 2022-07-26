using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Library 
    {
        protected List<Book> _books;
        protected List<Newspaper> _newspapers;

    }

    

    internal class Book
    {

        public int BookId { get; set; }
        public string BookName { get; set; }


    }
    internal class Newspaper
    {
        public int NewspaperId { get; set; }
        public string NewspaperName { get; set; }

    }
}
