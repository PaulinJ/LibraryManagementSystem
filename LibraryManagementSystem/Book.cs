using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public int CopiesAvailable { get; set; }
        private BookGenre genre;
        private bool isGenreValid = false;
        public string Genre
        {
            get
            {
                return genre.ToString();
            }
            set
            {
                bool isValid = Enum.TryParse<BookGenre>(value, true, out var result);

                // Validate the genre input
                while (!isValid || !Enum.IsDefined(typeof(BookGenre), result))
                {
                    WriteLine("Invalid entry for genre. Please select from the following list:");
                    WriteLine("1. Fiction");
                    WriteLine("2. NonFiction");
                    WriteLine("3. Science");
                    WriteLine("4. History");
                    WriteLine("5. Autobiography");
                    WriteLine("6. Self_Help");
                    WriteLine("7. Memoir");
                    WriteLine("8. Mystery");
                    WriteLine("9. Romance");
                    WriteLine("10. Thriller");

                    Write("Enter a valid genre: ");
                    value = Console.ReadLine();
                    isValid = Enum.TryParse<BookGenre>(value, true, out result); // Re-check validity
                }
                genre = result;
            }
        }

        // Constructor to initialize all properties
        public Book(string title, string author, string isbn, string genre, string publisher, int publicationYear, int copiesAvailable)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Genre = genre;
            this.Publisher = publisher;
            this.PublicationYear = publicationYear;
            this.CopiesAvailable = copiesAvailable;
        }

        // Method to check if the book is available
        public bool IsAvailable()
        {
            return CopiesAvailable > 0;
        }

        // Description of the book
        public string Description { get; set; }

        // Track how many times the book has been loaned out
        public int LoanCount { get; set; }
    }
}
