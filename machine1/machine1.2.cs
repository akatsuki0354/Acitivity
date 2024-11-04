using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace activity12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Machine Problem 1.2: Write a program that converts the input Celsius degree into its equivalent
            Fahrenheit degree. Use the formula: F = (9 / 5) * C + 32.

    double F, C, num1 = 9, num2 = 5, num3 = 32;

            Console.Write("Enter The Celcius degree: ");
            C = Convert.ToDouble(Console.ReadLine());

            F = (num1 / num2) * C + num3;

            Console.WriteLine("The equivalent of Celsius degree to Farenheit is: " + F);

        }
    }
}