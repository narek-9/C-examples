// Удалить вторую цифру трёхзначного числа
Random rnd = new Random();
int num = rnd.Next(100, 1000);
Console.WriteLine($"Рандомное число = {num}.");
Console.WriteLine($"{num / 100}" + num % 10);