using static System.Console;


namespace LibraryManagementSystem
{
    class Member : Person
    {
        public string MemberID { get; set; }
        public DateTime JoinDate { get; set; }
        public List<Loan> ActiveLoans { get; set; } 
        public bool IsActive { get; set; }
        public int LoanLimit { get; set; } = 5; 

        public Member(string fullName, string memberID, DateTime joinDate)
            : base(fullName, "", "", "", joinDate)  
        {
            this.MemberID = memberID;
            this.JoinDate = joinDate;
            ActiveLoans = new List<Loan>();
        }


        public bool CanBorrow()
        {
            return ActiveLoans.Count < LoanLimit;
        }

        
        public override void PrintDetails()
        {
            WriteLine($"Member ID: {MemberID}");
            WriteLine($"Full Name: {FullName}");
            WriteLine($"Join Date: {JoinDate.ToShortDateString()}");
            WriteLine($"Active Status: {(IsActive ? "Active" : "Inactive")}");
        }
    }
}
