  int total = 0;

  Console.WriteLine("Enter a Number: ");
  int input = Convert.ToInt32(Console.ReadLine());

  for (int i = 1; i <= input; i++) { 
  total += i;

      Console.Write(i + " + ");
  }
  Console.WriteLine("=" + total);