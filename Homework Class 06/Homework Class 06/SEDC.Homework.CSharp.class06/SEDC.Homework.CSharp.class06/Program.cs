using SEDC.Homework.CSharp.class06.Class;
using System;

namespace SEDC.Homework.CSharp.class06
{
    class Program
    {

        static void Main()
        {

            Driver driverOne = new Driver("Car1", 3);
            Driver driverTwo = new Driver("Car2", 5);
            Driver driverThree = new Driver("Car3", 4);
            Driver driverFour = new Driver("Car4", 2);

            Car carOne = new Car("Model1", 330);
            Car carTwo = new Car("Model2", 200);
            Car carThree = new Car("Model3", 220);
            Car carFour = new Car("Model4", 240);

            Car[] car = new Car[] { carOne, carTwo, carThree, carFour };
            Driver[] drivers = new Driver[] { driverOne, driverTwo, driverThree, driverFour };


            Console.WriteLine($"Choose the first bolid: \n1. {carOne.Model} \n2. {carTwo.Model} \n3. {carThree.Model} \n4. {carFour.Model} ");
            int car1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Choose the pilot for the first bolid: \n1. {driverOne.Name} \n2. {driverTwo.Name} \n3. {driverThree.Name} \n4. {driverFour.Name} ");
            int firstdriver = int.Parse(Console.ReadLine());

            car[car1 - 1].Racer = drivers[firstdriver - 1];

            Console.WriteLine($"Choose the second bolid: \n1. {carOne.Model} \n2. {carTwo.Model} \n3. {carThree.Model} \n4. {carFour.Model} ");
            int secondcar = int.Parse(Console.ReadLine());

            Console.WriteLine($"Choose the pilot for the second bolid: \n1. {driverOne.Name} \n2. {driverTwo.Name} \n3. {driverThree.Name} \n4. {driverFour.Name} ");
            int seconddriver = int.Parse(Console.ReadLine());

            car[secondcar - 1].Racer = drivers[seconddriver - 1];

            RaceCars(car[car1 - 1], car[secondcar - 1]);

            Console.ReadLine();

        }

        public static void RaceCars(Car number1, Car number2)
        {
            if (number1.Speed > number2.Speed)
            {
                Console.WriteLine("The winner is " + number1.Model);
            }
            else if (number2.Speed > number1.Speed)
            {
                Console.WriteLine("The winner is " + number2.Model);
            }
            else
            {
                Console.WriteLine("Please choose a valid driver and car");
            }
        }
    }
}
