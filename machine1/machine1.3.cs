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
            //Machine Problem 1.3: Write a program that converts the input dollar to its peso exchange rate
            //equivalent.Assume that the present exchange rate is 53.95 pesos against the dollar. Then display
            //the peso equivalent exchange rate.

            double input, D = 53.95, total;
            Console.Write("Enter the dollar: ");
            input = Convert.ToDouble(Console.ReadLine());

            total = input * D;

            Console.WriteLine("The equivalent in the dollar to peso is " + total);

        }
     }
}