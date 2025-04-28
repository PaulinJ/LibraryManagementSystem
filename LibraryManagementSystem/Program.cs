using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

enum BookGenre
{
    Fiction, NonFiction, Science, History, Autobiography, Self_Help, Memoir, Mystery, Romance, Thriller
}




namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create book and member instances
              Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "123456789", "Fiction", "Scribner", 1925, 3);
              Member member1 = new Member("John Doe", "M001", DateTime.Now);

              // Create a loan
              Loan loan1 = new Loan(book1, member1, DateTime.Now);

              // Check if the book is available
             // WriteLine($"Is '{book1.Title}' available? {book1.IsAvailable()}");

              // Add loan to member
              member1.ActiveLoans.Add(loan1);

              // Check if member can borrow more books
            //  WriteLine($"Can member borrow more books? {member1.CanBorrow()}");

              // Print member details
              member1.PrintDetails();

              // Check if the loan is overdue
              WriteLine($"Is the loan overdue? {loan1.IsOverdue()}");

              // Calculate late fee
              //WriteLine($"Late fee: {loan1.LateFee()}"); 


            

            Console.WriteLine(member1.ActiveLoans);
        }
    }
}
