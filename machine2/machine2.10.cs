using System;

class Program
{
    static void Main()
    {
        int grade;
        Console.Write("Enter Grade: ");
        grade = Convert.ToInt32(Console.ReadLine());
        if (grade >= 75 && grade <= 76)
        {
            Console.WriteLine("Grade Equivalent: 3.0");
        }
        else if (grade >= 77 && grade <= 79)
        {
            Console.WriteLine("Grade Equivalent: 2.75");
        }
        else if (grade >= 80 && grade <= 81)
        {
            Console.WriteLine("Grade Equivalent: 2.5");
        }
        else if (grade >= 82 && grade <= 84)
        {
            Console.WriteLine("Grade Equivalent: 2.25");
        }
        else if (grade >= 85 && grade <= 88)
        {
            Console.WriteLine("Grade Equivalent: 2.0");
        }
        else if (grade >= 89 && grade <= 91)
        {
            Console.WriteLine("Grade Equivalent: 1.75");
        }
        else if (grade >= 92 && grade <= 94)
        {
            Console.WriteLine("Grade Equivalent: 1.5");
        }
        else if (grade >= 95 && grade <= 97)
        {
            Console.WriteLine("Grade Equivalent: 1.25");
        }
        else if (grade >= 98 && grade <= 100)
        {
            Console.WriteLine("Grade Equivalent: 1.0");
        }

    }
}
