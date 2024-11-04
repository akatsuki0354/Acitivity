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
            // Machine Problem 1.6: Design a program to find the circumference of a circle. Use the formula:
            // C = 2r, where  is approximately equivalent to 3.1416.

           double total, c = 2, a = 3.1416, r;

           Console.Write("Enter The circ: ");
           r = Convert.ToDouble(Console.ReadLine());

           total = a * c * r;

           Console.WriteLine("Total: " + total);
        }
     }
}