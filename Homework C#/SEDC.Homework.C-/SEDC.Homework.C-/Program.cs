using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //    Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.
            //    * Test Data:
            //    *Enter the First number: 10
            //    * Enter the Second number: 15
            //    * Enter the Operation: +
            //    *Expected Output:
            //    *The result is: 25


            Console.WriteLine("Please enter the first number: ");

            string userNum1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number:");

            string userNum2 = Console.ReadLine();

            Console.WriteLine("Enter the operator: ");

            char operators = Convert.ToChar(Console.ReadLine());

            bool isValidFirstNumber = int.TryParse(userNum1, out int num1);

            bool isValidSecondNumber = int.TryParse(userNum2, out int num2);

            if(isValidFirstNumber && isValidSecondNumber)

            {
                switch (operators)
                {
                    case '+':
                        double result = num1 + num2;
                        Console.WriteLine("Your result is: " + result);
                        break;

                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("Your result is: " + result);
                        break;

                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("Your result is: " + result);
                        break;

                    case '/':
                        result = num1 / num2;
                        Console.WriteLine("Your result is: " + result);
                        break;

                }
            }

            else
            {
                Console.WriteLine("Please enter valid number!");
            }

            Console.ReadLine();




            // TASK 2 
            //  Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            //  *Test Data:
            //    *Enter the First number: 10
            //    * Enter the Second number: 15
            //    * Enter the third number: 20
            //    * Enter the four number: 30
            //  * Expected Output:
            //    *The average of 10, 15, 20 and 30 is: 18

            //Console.WriteLine("Please enter the first number: ");
            //string userNum1 = Console.ReadLine();

            //Console.WriteLine("Please enter the second number: ");
            //string userNum2 = Console.ReadLine();

            //Console.WriteLine("Please enter the third number: ");
            //string userNum3 = Console.ReadLine();

            //Console.WriteLine("Please enter the fourth number: ");
            //string userNum4 = Console.ReadLine();

            //int num1 = 0;

            //bool isValidFirstNumber = int.TryParse(userNum1, out int num1);

            //bool isValidSecondNumber = int.TryParse(userNum2, out int num2);

            //bool isValidThirdNumber = int.TryParse(userNum3, out int num3);

            //bool isValidFourthNumber = int.TryParse(userNum4, out int num4);

            //int results;

            //if (isValidFirstNumber && isValidSecondNumber && isValidThirdNumber && isValidFourthNumber)

            //{
            //    results = (num1 + num2 + num3 + num4) / 4;

            //    Console.WriteLine("The average number is " + results);

            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid number");

            //}
            // Koga ke vnesam bukva consola se gasi i ne mi dava "Please enter valids number", a so brojki funkcionira.



            //## Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
            //Please find example below:
            //* Test Data:
            //* Input the First Number: 5
            //* Input the Second Number: 8
            //* Expected Output:
            //* After Swapping:
            //* First Number: 8
            //* Second Number: 5

            //Console.WriteLine("Enter your first number: ");

            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your second number: ");

            //int number2 = Convert.ToInt32(Console.ReadLine());

            //int temp = number1;
            //number1 = number2;
            //number2 = temp;

            //Console.Write("\nYour first number: " + number1);

            //Console.Write("\nYour second number: " + number2);

            //Console.Read();
        }
    }
}
