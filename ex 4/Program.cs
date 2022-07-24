// Найти максимальное из трех чисел

Random rnd = new Random();
int num1 = rnd.Next(1, 100);
int num2 = rnd.Next(1, 100);
int num3 = rnd.Next(1, 100);

Console.WriteLine($"{num1}, {num2}, {num3}");

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Максимальное число = {num1}");
}

if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"Максимальное число = {num2}");
}

if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"Максимальное число = {num3}");
}
