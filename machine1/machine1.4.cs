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
             //Machine Problem 1.4: Write a program that converts an input inch(es) into its equivalent
            //centimeters.Take note that one inch is equivalent to 2.54 cms.

            double inch, total,  cms = 2.54 ;

            Console.WriteLine("Enter The inch: ");
            inch = Convert.ToDouble(Console.ReadLine()) ;

            total = inch * cms;

            Console.WriteLine("The equivalent of inch to cm is "+ total);
        }
     }
}