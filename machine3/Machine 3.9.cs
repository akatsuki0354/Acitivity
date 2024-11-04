  Console.Write("Input number: ");
  int number = int.Parse(Console.ReadLine());
  int reversed = 0;

  while (number > 0)
  {
      int lastDigit = number % 10; 
      reversed = reversed * 10 + lastDigit; 
      number /= 10; 
  }

  Console.WriteLine("Output: " + reversed);