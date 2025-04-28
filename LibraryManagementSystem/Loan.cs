using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Loan
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }  // Nullable to handle books not yet returned

        public Loan(Book book, Member member, DateTime loanDate)
        {
            Book = book;
            Member = member;
            LoanDate = loanDate;
        }

        // Check if the loan is overdue
        public bool IsOverdue()
        {
            if (ReturnDate == null && LoanDate.AddDays(14) < DateTime.Now) // Assuming a 14-day loan period
            {
                return true;
            }
            return false;
        }

        // Calculate late fee based on overdue days (if any)
        public decimal LateFee()
        {
            if (IsOverdue())
            {
                int overdueDays = (DateTime.Now - LoanDate).Days - 14;
                return overdueDays * 0.5m;  // Assume $0.50 per day late fee
            }
            return 0m;
        }
    }
}

