  int input, f = 1, s = 1, n;

  Console.Write("Enter the Number: ");
  input = Convert.ToInt32(Console.ReadLine());

  for (int i = 1; i <= input; i++) {
      Console.Write(f + " ");
      n = f + s;
      f = s;
      s = n;

      //f = 1 s = 1
      //n(2) = f (1) + s (1) <----- 
      //f = s the value is 1      |
      //s = n the value is 1      |
      //                          |
      // f = s(1)                 |
      // s = n(2)-----------------|   <----------
      // n(3) = f (1) + s (2) <------           |   
      // f = s(2)-------------------|-----------|
      // s = n(3)-------------------|
  }