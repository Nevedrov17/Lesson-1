Console.Clear();
Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write($"Максимальное число {a}");
}
else if (b > c)
{
    Console.Write($"Максимальное число {b}");
}
else Console.Write($"Максимальное число {c}");
