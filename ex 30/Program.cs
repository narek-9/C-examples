// Показать кубы чисел, заканчивающихся на четную цифру

Random rnd = new Random();
int num = rnd.Next(1, 100);
Console.WriteLine(num);
int result = 1;
if (num % 2 == 0)
{
    result = num * num * num;
    Console.WriteLine($"Куб числа {num} = {result}");
}
else
{
    Console.WriteLine($"Число {num} - нечётное.");
}