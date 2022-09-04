// Определить, присутствует ли в заданном массиве, некоторое число 

Console.WriteLine("Введите размер масиива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знаения масиива: ");
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int j = 0;

do
{
    if (array[j] == number)
    {
        Console.WriteLine($"Число {number} присутствует в масииве.");
        break;
    }
    else
    {
        j++;
    }
    if (j == size)
    {
        Console.WriteLine($"Числа {number} нет в масииве.");
    }
} while (j < size);
