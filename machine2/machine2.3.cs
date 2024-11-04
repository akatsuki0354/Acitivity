   double temp;
   Console.Write("Enter The temp: ");
   temp = Convert.ToDouble(Console.ReadLine());

   if (temp < 0)
   {
       Console.WriteLine("ICE");
   }
   else if (temp >= 0 && temp <= 100)
   {
       Console.WriteLine("Water");
   }
   else
   {
       Console.WriteLine("steam");
   }