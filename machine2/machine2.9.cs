using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double input,amount,discount10Percent,discount5Percent,interest5Percent;

            Console.Write("Enter Tuition Fee Amount: ");
            amount = Convert.ToDouble(Console.ReadLine());

          
            Console.WriteLine("Please Select Payment Plan");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Two Installment");
            Console.WriteLine("3. Three Installment");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
             input = Convert.ToInt32(Console.ReadLine());


             discount10Percent = amount * 0.10;
             discount5Percent = amount * 0.05;
             interest5Percent = amount * 0.05;

            if (input == 1)
            {
                Console.WriteLine("Cash");
                Console.WriteLine($"Your Total Tuition Fee is: {amount - discount10Percent}");
            }
            else if (input == 2)
            {
                Console.WriteLine("Two Installments");
                Console.WriteLine($"Your Total Tuition Fee is: {amount - discount5Percent}");
            }
            else if (input == 3)
            {
                Console.WriteLine("Three Installments");
                Console.WriteLine($"Your Total Tuition Fee is: {amount + interest5Percent}");
            }
            else if (input == 0)
            {
                Console.WriteLine("Thank You for Using the Program");
                Console.WriteLine("Exiting the Program");
            }
            else
            {
                Console.WriteLine("Invalid Input Please Try Again");
            }
        }
    }
}

