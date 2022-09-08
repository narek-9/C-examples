// Выяснить являются ли три числа сторонами треугольник

Console.WriteLine("Введите первую сторону: ");
Console.WriteLine("Введите первую сторону: ");
Console.WriteLine("Введите первую сторону: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if ((num1 + num2 <= num3) | (num1 + num3 <= num2) | (num2 + num3 <= num1))
{
    Console.WriteLine($"Числа {num1}, {num2} и {num3} - не стороны треугольника.");
}
else
    Console.WriteLine($"Числа {num1}, {num2} и {num3} - стороны треугольника.");


