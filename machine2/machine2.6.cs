using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N;
            Console.Write("Enter The Number: ");
            N = Convert.ToDouble(Console.ReadLine());

            if (N < 5.0)
            {
                Console.WriteLine("Little or no damage");
            }
            else if (N >= 5.0 && N < 5.5)
            {
                Console.WriteLine("Some Damage");
            }
            else if (N >= 5.5 && N < 6.5)
            {
                Console.WriteLine("Serious damage");
            }
            else if (N >= 6.5 && N < 7.5)
            {
                Console.WriteLine("Disaster");
            }else{
                Console.WriteLine("Castrophe");
            }
        }

    }
}

