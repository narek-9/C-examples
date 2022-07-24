// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());


if (num1 == num2 * num2)
{
    Console.WriteLine($"Число {num1} - квадрат числа {num2}");
}

else
{
    Console.WriteLine($"Число {num1} - не квадрат числа {num2}");
}