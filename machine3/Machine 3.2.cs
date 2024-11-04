 Console.WriteLine("Enter the number: ");
 int num = int.Parse(Console.ReadLine());
 for (int x = 1, y = num; x <= num; x++, y--)
 {
     Console.Write(" " + x + " " + y);
 }