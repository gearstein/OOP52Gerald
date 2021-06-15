using System;
using System.Collections.Generic;
using System.Text;

namespace OOP52
{
    class Manager : Employee
    {
        public int Allowance { get; set; }

        public Manager()
        {

        }
        public Manager(string nIK, string firstName, string lastName, string email, int salary, int allowance)
        {
            NIK = nIK;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Salary = salary;
            Allowance = allowance;  
        }

        public override void ShowData()
        {
            Console.WriteLine($"NIK : {NIK}");
            Console.WriteLine(GetFullName());
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Allowance : {Allowance}");
        }
    }
}
