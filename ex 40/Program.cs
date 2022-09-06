// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Random rnd = new Random();
double[] array = new double[rnd.Next(1, 10)];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.NextDouble() * rnd.Next(5, 10);
    Console.Write(Math.Round(array[i], 2));
    if (i == array.Length - 1)
    {
        break;
    }
    Console.Write(", ");
}
Console.WriteLine("]");

double max = 0;
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Максимальный элемент = " + Math.Round(max, 2));
Console.WriteLine("Минимальный элемент = " + Math.Round(min, 2));

Console.WriteLine($"Разница = {Math.Round(max - min, 2)}");