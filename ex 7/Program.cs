// Показать числа от -N до N

Console.WriteLine("Введите отрицательное число: ");
int number = int.Parse(Console.ReadLine());
int i = number;

while (i <= -number)
{
    Console.Write($"{number}, ");
    number++;
}