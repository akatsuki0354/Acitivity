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
            //Machine Problem 1.5: Write a program that exchanges the value of two variables : x and y.The
            //output must be: The value of variable y will become the value of variable x, and vise versa.

                int y = 6;
                int x = 5;
                int s = x;
                x = y;
                y = s;

            Console.WriteLine("x=" + x + "\ny=" +y);
        }
     }
}