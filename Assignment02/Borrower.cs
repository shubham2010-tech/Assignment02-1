using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Borrower :Library
    {
        
        protected List<BorrowerList> _borrowers;
        protected List<BookBorrowed> _bookBorroweds;


        public void AddBorrower(BorrowerList newborrower)
        {
            if (_borrowers == null)
            {
                _borrowers = new List<BorrowerList>();
            }
            _borrowers.Add(newborrower);
        }
        public void AddNewBorrower(object obj, string Name, int BOId, CrudOperationOnBook b)
        {
            if (obj is Book)
            {
                Book book = (Book)obj;
                BookBorrowed newb = new BookBorrowed()
                {
                    BookID = book.BookId,
                    BookName = book.BookName,
                    BorrowedId = BOId,
                    BorrowedName = Name
                };

                if (_bookBorroweds == null)
                {
                    _bookBorroweds = new List<BookBorrowed>();
                }
                _bookBorroweds.Add(newb);

            }
            else if (obj is Newspaper)
            {
                Newspaper newspaper = (Newspaper)obj;
                NewspaperBorrowed newn = new NewspaperBorrowed()
                {
                    NewsPaperID = newspaper.NewspaperId,
                    NewsPaperName = newspaper.NewspaperName,
                    BorrowedId = BOId,
                    BorrowedName = Name
                };

                if (_NewspaperBorroweds == null)
                {
                    _NewspaperBorroweds = new List<NewspaperBorrowed>();
                }
                _NewspaperBorroweds.Add(newn);
            }

        }

    }
    internal class BorrowerList:Borrower
    {
        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }
    }
    class BookBorrowerList:Borrower,IEnumerable
    {
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
    
}
