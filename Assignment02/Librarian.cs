using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Librarian : Library,IEnumerable
    {
        //Books       
        public void AddBook(Book NewBook)
        {
            if(_books == null)
            {
                _books = new List<Book>();
            }
            _books.Add(NewBook);
        }
        public void RemoveBook(Book AvailableBooks)
        {
            _books.Remove(AvailableBooks);
        }
        public Book this[string fbook, string bid]
        {
            
            get
            {
                Book fb = null;
                int a=-1;
                try
                {
                    a = Convert.ToInt32(bid);
                }
                catch
                {
                    bid = null;
                }
                
                foreach (Book b in _books)
                {
                    if (b.BookName == fbook || b.BookId==a)
                    {

                        fb = b;
                        break;
                    }
                }
                return fb;
            }
            
        }
        


        //Newspaper
        public void AddNewsPaper(Newspaper Newnewspaper)
        {
            if (_newspapers == null)
            {
                _newspapers = new List<Newspaper>();
            }
            _newspapers.Add(Newnewspaper);
        }
        public void RemoveNewspaper(Newspaper newspaper)
        {
            _newspapers.Remove(newspaper);
        }
        public Newspaper this[string nName]
        {

            get
            {
                Newspaper fn = null;
                

                foreach (Newspaper n in _newspapers)
                {
                    if (n.NewspaperName == nName )
                    {

                        fn = n;
                        break;
                    }
                }
                return fn;
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
            else if (_newspapers != null)
            {
                foreach (Newspaper AvailableNP in _newspapers)
                {
                    yield return AvailableNP;
                }
            }
            else
            {
                yield break;
            }
        }
    }

    
}
