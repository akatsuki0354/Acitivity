using System;

class Program
{
    static void Main()
    {   
        int num;
        Console.Write("Enter a number you want: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num <= 0 || num > 3000)
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 3000.");
        }
        else
        {
            string romanNumeral = ""; // Initialize here

            if (num >= 1000)
            {
                romanNumeral += new string('M', num / 1000);
                num %= 1000;
            }
            if (num >= 900)
            {
                romanNumeral += "CM";
                num -= 900;
            }
            else if (num >= 500)
            {
                romanNumeral += "D";
                num -= 500;
            }
            else if (num >= 400)
            {
                romanNumeral += "CD";
                num -= 400;
            }
            if (num >= 100)
            {
                romanNumeral += new string('C', num / 100);
                num %= 100;
            }
            if (num >= 90)
            {
                romanNumeral += "XC";
                num -= 90;
            }
            else if (num >= 50)
            {
                romanNumeral += "L";
                num -= 50;
            }
            else if (num >= 40)
            {
                romanNumeral += "XL";
                num -= 40;
            }
            if (num >= 10)
            {
                romanNumeral += new string('X', num / 10);
                num %= 10;
            }
            if (num == 9)
            {
                romanNumeral += "IX";
                num -= 9;
            }
            else if (num >= 5)
            {
                romanNumeral += "V";
                num -= 5;
            }
            else if (num == 4)
            {
                romanNumeral += "IV";
                num -= 4;
            }

            romanNumeral += new string('I', num);

            Console.WriteLine($"The equivalent Roman numeral is: {romanNumeral}");
        }
    }
}
