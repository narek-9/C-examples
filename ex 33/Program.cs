// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

Random rnd = new Random();
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-9, 10);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
int posResult = 0;
int negResult = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        posResult += array[i];
    }
    else
        negResult += array[i];
}
Console.WriteLine($"Сумма положительных элментов = {posResult}");
Console.WriteLine($"Сумма отрицательных элментов = {negResult}");