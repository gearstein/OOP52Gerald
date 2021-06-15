using System;
using System.Collections.Generic;
using System.Text;

namespace OOP52
{
    class Employee
    {
        public string NIK { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public int Salary { get; set; }

        public Employee()
        {
            Console.WriteLine("Object Baru Terbuat");
        }

        public Employee(string nIK, string firstName, string lastName, string email, int salary)
        {
            NIK = nIK;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Salary = salary;
        }

        public string GetFullName()
        {
            //return "Full Name : " + first_name + " " + last_name;
            return $"Full Name : {FirstName} {LastName}";
        }

        public void RaiseSalary(float multiplier)
        {
            Salary = Convert.ToInt32(Salary + (Salary * multiplier));
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"NIK : {NIK}");
            Console.WriteLine(GetFullName());
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Email : {Email}");
        }
    }
}
