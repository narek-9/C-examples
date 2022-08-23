// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Random rnd = new Random();
int num = rnd.Next(1, 1000);
Console.WriteLine("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Рандомное число = {num}.");
Console.WriteLine($"Заданное число = {num2}.");

if (num % num2 != 0)
    Console.WriteLine("Рандомное число не кратно заданному.");
else
    Console.WriteLine("Рандомное число кратно заданному.");
