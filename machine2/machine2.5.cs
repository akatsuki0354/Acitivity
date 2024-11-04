  char letter;
  Console.WriteLine("choose letter B, C, D, F ");
  Console.Write("Enter The letter: ");
  letter = char.ToLowerInvariant(Console.ReadLine()[0]);

  if (letter == 'b')
  {
      Console.WriteLine("Battleship");
  }
  else if (letter == 'c')
  {
      Console.WriteLine("Cruiser");
  }
  else if (letter == 'd')
  {
      Console.WriteLine("Destroyer");
  }
  else if (letter == 'f')
  {
      Console.WriteLine("Frigate");
  }