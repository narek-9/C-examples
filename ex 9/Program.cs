// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число: ");

int num = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(num);

int result = num % 10;
Console.WriteLine($"Последняя цифра числа = {result}");

