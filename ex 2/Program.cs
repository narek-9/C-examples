// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} - большее число, {num2} - меньшее число.");
}

else if (num2 > num1)
{
    Console.WriteLine($"{num2} - большее число, {num1} - меньшее число.");

}

if (num1 == num2)
{
    Console.WriteLine("Числа равны.");
}