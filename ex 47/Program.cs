// Написать программу копирования массива

Console.Write("Введите значения массива через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int[] array2 = new int[array.Length];
// Array.Copy(array, array2, array2.Length);
for (int i = 0; i < array.Length; i++)
{
    array2[i] = array[i];
}

Console.WriteLine("Первоначальный массив: " + "[" + string.Join(", ", array) + "]");
Console.WriteLine("Скопированный массив: " + "[" + string.Join(", ", array2) + "]");