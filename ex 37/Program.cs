// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Random rnd = new Random();
int[] array = new int[123];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 1000);
    if (array[i] > 9 & array[i] < 100)
    {
        count++;
    }
}

Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");

// Решение со значениями в масииве до 123

// Random rnd = new Random();
// int[] array = new int[rnd.Next(1, 40)];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(1, 124);
//     if (array[i] > 9 & array[i] < 100)
//     {
//         count++;
//     }
// }

// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");
