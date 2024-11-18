Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
int reversed = 0;

while (number > 0)
{
    reversed = reversed * 10 + (number % 10);
    number /= 10;
}

Console.WriteLine($"Output: {reversed} ");
