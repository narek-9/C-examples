// Показать таблицу квадратов чисел от 1 до N 

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} * {i} = " + i * i);
}