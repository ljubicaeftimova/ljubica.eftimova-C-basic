using SEDC.Homework.Class07.CSharp.Class;
using System;

namespace SEDC.Homework.Class07.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager Filip = new Manager("Ljubica", "Eftimova", Role.Manager, 1000);

            Console.WriteLine($"The salary of {Filip.FirstName} {Filip.LastName} is:" + " " + Filip.GetSalary());

            Filip.AddBonus(1500);

            SalesPerson Trajan = new("Trajan", "Stevkovski", Role.Sales, 2000);

            Console.WriteLine($"The salary of {Filip.FirstName} {Filip.LastName} is:" + " " + Filip.GetSalary());

            Console.WriteLine($"The salary of {Trajan.FirstName} {Trajan.LastName} is:" + " " + Trajan.GetSalary());

            Console.ReadLine();
        }
    }
}
