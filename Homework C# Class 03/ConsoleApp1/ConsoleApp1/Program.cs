using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //  Make a console application called SumOfEven. Inside it create an array of 6 integers.Get numbers from the input, find and print the sum of the even numbers from the array:
            //* Test Data:
            //  *Enter integer no.1:
            //    * 4
            //  * Enter integer no.1:
            //    * 3
            //  * Enter integer no.1:
            //    * 7
            //  * Enter integer no.1:
            //    * 3
            //  * Enter integer no.1:
            //    * 2
            //  * Enter integer no.1:
            //    * 8
            //* Expected Output:
            //    *The result is: 14


            //int sum = 0;
            //string[] array = new string[6];

            //Console.WriteLine("Enter your number : ");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[" + (i + 1) + "]: ");

            //    array[i] = Console.ReadLine();

            //    bool isValidNumber = int.TryParse(array[i], out int num1);

            //    if (isValidNumber)
            //    {

            //        if (num1 % 2 == 0)
            //        {
            //            sum = sum + num1;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid number!");
            //        break;
            //    }
            //}

            //Console.WriteLine("Sum of the even numbers is:" + sum);
            //Console.ReadLine();


            //## Task 2
            //* Make a new console application called StudentGroup
            //* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //* Get a number from the console between 1 and 2 and print the students from that group in the console.
            //* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //* Test Data:
            //  * Enter student group: (there are 1 and 2 )
            //    *1
            //* Expected Output:
            //  * The Students in G1 are: 
            //  * Zdravko
            //  * Petko
            //  * Stanko
            //  * Branko
            //  * Trajko  


            Console.Write("Please enter student group: ");

            //string inputArray = Console.ReadLine();

            int inputArray = Convert.ToInt32(Console.ReadLine());

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentsG2 = { "Ljubica", "Marija", "Monika", "Ivana", "Angela" };


            switch (inputArray)
            {
                case 1:
                    Console.WriteLine("The first group is: ");
                    for (int i = 0; i < studentsG1.Length; i++)
                    {
                        Console.WriteLine(studentsG1[i]);
                    }
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("The second group is: ");
                    for (int i = 0; i < studentsG2.Length; i++)
                    {
                        Console.WriteLine(studentsG2[i]);
                    }
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}