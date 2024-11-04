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
            
            //Machine Problem 1.9: Determine the most economical quantity to be stocked for each product
            //that a manufacturing company has in its inventory.This quantity, called economic order quantity
            //(EOQ) is calculated as follows: EOQ = sqrt(2RS) / I   
            //where:
            //R = total yearly production requirement
            //S = set up cost per order
            //I = inventory carrying cost per unit


             double num1 = 2, R, S, I, EOQ;


              Console.Write("Enter the yearly production: ");
             R = Convert.ToDouble(Console.ReadLine());

              Console.Write("Enter the cost per order: ");
              S = Convert.ToDouble(Console.ReadLine());

              Console.Write("Enter the inventory carrying cost per unit: ");
             I = Convert.ToDouble(Console.ReadLine());

              EOQ = Math.Sqrt((num1 * R * S) / I);

              Console.WriteLine("The Economic Order Quantity is: " + EOQ);
        }
     }
}