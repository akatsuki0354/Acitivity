  int input, total = 0;
  Console.WriteLine("Enter a Number: ");
  input = Convert.ToInt32(Console.ReadLine());
  for (int i = 1; i <= input; i++)
  {
      total += i * i;
      Console.Write($"{i}^2");
      if (i < input)
          Console.Write(" + ");
      
  }
  Console.WriteLine(" =" + total);