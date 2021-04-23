using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Class07.CSharp.Class
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName, Role role, double salary) : base(firstName, lastName, role)
        {
            Salary = salary;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
    }
}
