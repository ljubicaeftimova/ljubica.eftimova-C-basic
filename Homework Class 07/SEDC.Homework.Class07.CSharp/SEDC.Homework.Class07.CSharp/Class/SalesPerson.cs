using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Class07.CSharp.Class
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string FirstName, string LastName, Role Role, double SucceessRevenue) : base(FirstName, LastName, Role)
        {
            Salary = 500;
            SuccessSaleRevenue = SucceessRevenue;
        }

        private double SuccessSaleRevenue { get; set; }

        public void AddSaleRevenue(double saleRevenue)
        {
            SuccessSaleRevenue += saleRevenue;
        }

        public override double GetSalary()
        {
            int bonus = 0;
            double baseSalary = base.GetSalary();

            if (SuccessSaleRevenue <= 2000)
            {
                bonus += 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                bonus += 1000;
            }
            else
            {
                bonus = 1500;
            }

            return baseSalary + bonus;
        }
    }
}
