// Найти сумму чисел одномерного массива стоящих на нечетной позиции 

Random rnd = new Random();
int[] array = new int[rnd.Next(1, 20)];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 150);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Сумма чисел элементов на нечетных позициях = {sum}");