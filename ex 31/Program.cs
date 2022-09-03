// Задать массив из 8 элементов и вывести их на экран

Random rnd = new Random();
int[] array = new int[8];
Console.WriteLine("Введите значения массива: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[" + string.Join(", ", array) + "]");