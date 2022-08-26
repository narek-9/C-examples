// Дано число. Проверить кратно ли оно 7 и 23

Random rnd = new Random();
int num = rnd.Next(10, 1000);
Console.WriteLine($"Заданное число = {num}.");
if (num % 7 == 0 & num % 23 == 0)
    Console.WriteLine("Число кратно 7 и 23.");
else
    Console.WriteLine("Число не кратно 7 и 23.");