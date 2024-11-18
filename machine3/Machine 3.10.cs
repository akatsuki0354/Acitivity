 int sum = 0;

 Console.WriteLine("Enter a Number: ");
 int input = Convert.ToInt32(Console.ReadLine());

 for (int i = 1; i <= input; i++)
 {
     sum += (int)Math.Pow(i, i);
     total = (int)Math.Pow(i, i);
     Console.WriteLine($"{i}^{i} = {total}");
    }

 Console.WriteLine(" = " + sum);