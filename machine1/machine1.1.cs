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
            // Machine Problem 1.1: Create a program to compute the volume of a sphere. Use the formula:
         
            V = (4 / 3) *r
            3 where  is equal to 3.1416 approximately.The variable r is the radius. Display
            the volume of a sphere.

            double r, v, pie = 3.1416;
            Console.Write("Enter the radius:");
            r = Convert.ToDouble(Console.ReadLine());

            v = (4/3) * pie * r * r * r;

            Console.WriteLine("The value of radius: " + v);
        }
    }
}
