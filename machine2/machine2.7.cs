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
            Console.Write("Enter a number you want (up to 3000): ");
            int num = int.Parse(Console.ReadLine());


            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            int thousands = num / 1000;
            num %= 1000;
            int hundreds = num / 100;
            num %= 100;
            int tensPlace = num / 10;
            int onesPlace = num % 10;

            // Print the number in words
            if (thousands > 0)
            {
                Console.Write(ones[thousands] + " Thousand ");
            }
            if (hundreds > 0)
            {
                Console.Write(ones[hundreds] + " Hundred ");
            }
            if (tensPlace == 1 && onesPlace != 0)
            {
                Console.Write(teens[onesPlace] + " ");
            }
            else
            {
                if (tensPlace > 0)
                {
                    Console.Write(tens[tensPlace] + " ");
                }
                if (onesPlace > 0)
                {
                    Console.Write(ones[onesPlace] + " ");
                }
            }
            Console.WriteLine();
        }

    }
}


