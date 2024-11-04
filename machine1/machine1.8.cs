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
            
           //Machine Problem 1.8: Write a program that takes as input the purchase price of an item(P), its
            //expected number of years of service(Y) and its expected salvage value(S).Then outputs the
            //yearly depreciation for the item (D). Use the formula: D = (P - S) / Y

           double P , Y, S, D;

           Console.Write("Enter the purchase price of the item: ");
           P = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter the expected number of years of service: ");
           Y = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter the expected salvage value of the item: ");
           S = Convert.ToDouble(Console.ReadLine());


           D = (P - S) / Y;

           Console.WriteLine("The yearly depreciation is: " + D);
        }
     }
}