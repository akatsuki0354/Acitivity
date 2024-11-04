 int r = 1;
 Console.Write("Enter the Number: ");
 int input1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter the Exponent: ");
 int input2 = Convert.ToInt32(Console.ReadLine());


 for (int i = 0; i < input2; i++)
 {
     r *= input1;
     Console.Write(input1);
     if (i < input1)
         Console.Write(" + ");
 }
 Console.Write("=" + r);
