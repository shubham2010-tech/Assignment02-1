using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Borrower :Library
    {
        
        protected List<BorrowerList> _borrowers;
        

        public void AddBorrower(BorrowerList newborrower)
        {
            if (_borrowers == null)
            {
                _borrowers = new List<BorrowerList>();
            }
            _borrowers.Add(newborrower);
        }
        
    }
    internal class BorrowerList:Borrower
    {
        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }
    }
    
}
