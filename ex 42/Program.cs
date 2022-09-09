// Определить сколько чисел больше 0 введено с клавиатуры 
Console.Write("Введите числа через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел > 0 = {count}");