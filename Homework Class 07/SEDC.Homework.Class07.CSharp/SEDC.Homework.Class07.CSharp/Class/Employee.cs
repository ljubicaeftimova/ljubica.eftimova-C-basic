using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Class07.CSharp.Class
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }
        public Employee(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName}, {LastName}, salary is: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
