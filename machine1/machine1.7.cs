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
            
            //an equation that exchanges the value of variable x and y.The hint is: use 3 equations that
            //involve with plus and minus operations.
            //Write your codes
            //Machine Problem 1.7: You can solve the worded - problem number 5 with the use of three
            //variables declaration.Now try to solve it with only two variables declaration. Formulate with an
            //equation that exchanges the value of variable x and y.The hint is: use 3 equations that involve
            //with plus and minus operations

            double x,y;

            Console.Write("Enter The X Value: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter The Y Value: ");
            y = Convert.ToDouble(Console.ReadLine());


            x = x + y;  

             y = x - y;  

            x = x - y; 
            Console.WriteLine("x = " + x + ", y = " + y);
        }
     }
}