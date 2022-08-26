// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"Число {num1} = квадрат числа {num2}.");
}

if (num2 == num1 * num1)
{
    Console.WriteLine($"Число {num2} = квадрат числа {num1}.");
}

if (num1 != num2 * num2 & num2 != num1 * num1)
{
    Console.WriteLine("Ни одно число не квадрат второго.");
}


