  double month, days, year;

  Console.Write("Enter The months:");
  month = Convert.ToDouble(Console.ReadLine());

  Console.Write("Enter The days: ");
  days = Convert.ToDouble(Console.ReadLine());

  Console.Write("Enter The Year: ");
  year = Convert.ToDouble(Console.ReadLine());


  switch (month) {
      case 1:
          Console.WriteLine("January " + days + ", " + year);
          break;
      case 2:
          Console.WriteLine("February " + days + ", " + year);
          break;
      case 3:
          Console.WriteLine("March " + days + ", " + year);
          break;
      case 4:
          Console.WriteLine("April " + days + ", " + year);
          break;
      case 5:
          Console.WriteLine("May " + days + ", " + year);
          break;
      case 6:
          Console.WriteLine("June " + days + ", " + year);
          break;
      case 7:
          Console.WriteLine("July " + days + ", " + year);
          break;
      case 8:
          Console.WriteLine("August " + days + ", " + year);
          break;
      case 9:
          Console.WriteLine("September " + days + ", " + year);
          break;
      case 10:
          Console.WriteLine("October " + days + ", " + year);
          break;
      case 11:
          Console.WriteLine("November " + days + ", " + year);
          break;
      case 12:
          Console.WriteLine("December " + days + ", " + year);
          break;
  }