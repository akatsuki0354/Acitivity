  int input, total = 1;

  Console.Write("Enter the Number: ");
  input = Convert.ToInt32(Console.ReadLine());

  for (int i = 1; i <= input; i++) {
       total *= i;
      Console.Write(total);

  }