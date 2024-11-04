 double kh, m;
 Console.Write("Enter The kh: ");
 kh = Convert.ToDouble(Console.ReadLine());
 Console.Write("Enter The m: ");
 m = Convert.ToDouble(Console.ReadLine());

 if (kh > 1100 && m > 52)
 {
     Console.WriteLine("Civilian Aircraft");
 }
 else if (kh < 1100 && m < 52)
     {
     Console.WriteLine("Military Aircraft");
 }
     else if (kh > 500 && m > 20)
     {
     Console.WriteLine("Military Aircraft");
 }
     else if (kh < 500 && m < 20)
     {
     Console.WriteLine("It's a bird");
 }