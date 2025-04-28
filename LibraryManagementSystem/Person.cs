using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
     abstract class Person
    {
        public string FullName {  get; set; }
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
       
       public Person(string fullName, string address, string phoneNumber, string email, DateTime dateOfBirth)
        { 
            this.FullName = fullName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;

        }

        public abstract void PrintDetails();



    }
}
