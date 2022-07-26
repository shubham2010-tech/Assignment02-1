using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    abstract class Borrower :Library
    {
        
        protected List<BorrowerList> _borrowers;


        public void AddBorrower(BorrowerList newborrower)
        {
            if (_borrowers == null)
            {
                _borrowers = new List<BorrowerList>();
            }
            _borrowers.Add(newborrower);
        } //Add Borrower
        public void AddNewBorrower(object obj, string Name, int BOId)
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

        }//Adding Newspaper and Book Borrower

        abstract public void Returning(object a,object b);

    }
    internal class BorrowerList:Borrower
    {
        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }

        public override void Returning(object a, object b)
        {
            throw new NotImplementedException();
        }
    }

    //Book Borrower List
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

        public override void Returning(object A,object B) //Returning Book
        {
            BookBorrowed b = (BookBorrowed)A;
            CrudOperationOnBook cb = (CrudOperationOnBook)B;
            cb.AddBook(new Book() { BookId=b.BookID,BookName=b.BookName });
            Console.WriteLine($"{b.BookName} is Returned Successfully\n:::Have A Nice Day:::\n");
            _bookBorroweds.Remove(b);
        }
        public BookBorrowed this[string BookName] //Check if Book is Issued
        {

            get
            {
                BookBorrowed fb = null;
                

                foreach (BookBorrowed bb in _bookBorroweds)
                {
                    if (bb.BookName == BookName)
                    {

                        fb = bb;
                        break;
                    }
                }
                return fb;
            }

        }
    }


    //Newspaper Borrower List
    class NewspaperBorrowerList : Borrower, IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            if (_NewspaperBorroweds != null)
            {
                foreach (NewspaperBorrowed AvailablN in _NewspaperBorroweds)
                {
                    yield return AvailablN;
                }
            }
            else
            {
                yield break;
            }
        }

        public override void Returning(object A,object B) //Returning Newspaper
        {
            NewspaperBorrowed n = (NewspaperBorrowed)A;
            CrudOperationOnNewspaper cn = (CrudOperationOnNewspaper)B;
            cn.AddNewspaper(new Newspaper() { NewspaperId = n.NewsPaperID, NewspaperName = n.NewsPaperName });
            Console.WriteLine($"{n.NewsPaperName} is Returned Successfully\n:::Have A Nice Day:::\n");
            _NewspaperBorroweds.Remove(n);
        }
        public NewspaperBorrowed this[string NewspaperName] //Check if Newspaper is Issued
        {
            get
            {
                NewspaperBorrowed fn = null;

                foreach (NewspaperBorrowed bn in _NewspaperBorroweds)
                {
                    if (bn.NewsPaperName == NewspaperName)
                    {
                        fn = bn;
                        break;
                    }
                }
                return fn;
            }

        }
    }

}
