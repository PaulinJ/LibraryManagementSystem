using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Staff : Person
    {
        public string StaffID { get; set; }
        public string Role { get; set; }

        public Staff(string fullName, string staffID, string role, DateTime dateOfBirth)
            : base(fullName, "", "", "", dateOfBirth)
        {
            StaffID = staffID;
            Role = role;
        }


        public override void PrintDetails()
        {
            WriteLine($"Staff ID: {StaffID}");
            WriteLine($"Full Name: {FullName}");
            WriteLine($"Role: {Role}");
        }
    }
}
