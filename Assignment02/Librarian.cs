using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    abstract class Librarian : Library
    {
         public  Librarian()
        {
            //Book
            AddBook(new Book() { BookId = 1, BookName = "Avenger Secret War" });
            AddBook(new Book() { BookId = 2, BookName = "Black Adam" });
            AddBook(new Book() { BookId = 3, BookName = "Shazam" });
            AddBook(new Book() { BookId = 4, BookName = "GOT" });
            AddBook(new Book() { BookId = 5, BookName = "IronHeart" });
            AddBook(new Book() { BookId = 6, BookName = "D." });
            AddBook(new Book() { BookId = 7, BookName = "Death Note" });
            AddBook(new Book() { BookId = 8, BookName = "World War" });
            AddBook(new Book() { BookId = 9, BookName = "C#" });
            AddBook(new Book() { BookId = 10, BookName = "New Life" });
            //Newspaper
            AddNewspaper(new Newspaper() { NewspaperId = 1, NewspaperName = "HindustanTimes" });
            AddNewspaper(new Newspaper() { NewspaperId = 2, NewspaperName = "Global Times" });
            AddNewspaper(new Newspaper() { NewspaperId = 3, NewspaperName = "Times of India" });
            AddNewspaper(new Newspaper() { NewspaperId = 4, NewspaperName = "Dainik Jagaran" });
            AddNewspaper(new Newspaper() { NewspaperId = 5, NewspaperName = "IndianTimes" });
        }
        public void AddBook(Book newbook)
        {
            if (_books == null)
            {
                _books = new List<Book>();
            }
            _books.Add(newbook);
        }
        public void AddNewspaper(Newspaper newspaper)
        {

            if (_newspapers == null)
            {
                _newspapers = new List<Newspaper>();
            }
            _newspapers.Add(newspaper);
        }
        abstract public void Remove(object obj);
        
    }
    class CrudOperationOnNewspaper:Librarian,IEnumerable
    {
        
        public override void Remove(object o)
        {
            Newspaper newspaper = (Newspaper)o;
            _newspapers.Remove(newspaper);
        }
        public Newspaper this[string NN, string NI]
        {

            get
            {
                Newspaper fb = null;
                int a ;
                try
                {
                    a = Convert.ToInt32(NI);
                }
                catch
                {
                    a = -1;
                }

                foreach (Newspaper n in _newspapers)
                {
                    if (n.NewspaperName == NN || n.NewspaperId == a)
                    {

                        fb = n;
                        break;
                    }
                }
                return fb;
            }

        }
        public IEnumerator GetEnumerator()
        {
            if (_newspapers != null)
            {
                foreach (Newspaper AvailableN in _newspapers)
                {
                    yield return AvailableN;
                }
            }

            else
            {
                yield break;
            }
        }
    }
    class CrudOperationOnBook : Librarian, IEnumerable
    {

        public override void Remove(object o)
        {
             Book book = (Book)o;
            _books.Remove(book);
        }
        public Book this[string fbook, string bid]
        {

            get
            {
                Book fb = null;
                int a ;
                try
                {
                    a = Convert.ToInt32(bid);
                }
                catch
                {
                    a = 0;
                }

                foreach (Book b in _books)
                {
                    if (b.BookName == fbook || b.BookId == a)
                    {

                        fb = b;
                        break;
                    }
                }
                return fb;
            }

        }
        public IEnumerator GetEnumerator()
        {
            if (_books != null)
            {
                foreach (Book AvailableBook in _books)
                {
                    yield return AvailableBook;
                }
            }

            else
            {
                yield break;
            }
        }
    }
}
