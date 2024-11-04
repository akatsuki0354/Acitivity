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
            
          

            //Machine Problem 1.10: Write a program to compute the radius of a circle. Derive your formula
            //from the given equation: A =r2, then display the output.



            double r, A, pi = 3.1416;


             Console.Write("Enter the radius: ");
             r = Convert.ToDouble(Console.ReadLine());


             A = pi * r * r;

            Console.WriteLine($"The area of a circle with radius {r} is: {A}");

        }
     }
}