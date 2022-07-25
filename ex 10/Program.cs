// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 999 || number < 100)
{
    Console.WriteLine("ВВЕДИТЕ ТРЁХЗНАЧНОЕ ЧИСЛО!!!");
}
else
{
    int result = number / 10 % 10;
    Console.WriteLine();
    Console.WriteLine($"Вторая цифра числа = {result}");
}