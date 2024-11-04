using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
 Console.WriteLine("Enter the number: ");
 int num = int.Parse(Console.ReadLine());
 for (int x = 1, y = num; x <= num; x++, y--)
 {
     Console.Write(" " + x + " " + y);
 }
        }
    }
}
