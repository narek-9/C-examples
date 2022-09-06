// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Random rnd = new Random();
int[] array = new int[rnd.Next(1, 20)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 10);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

int result = 0;
int n = array.Length - 1;
for (int i = 0; i < array.Length; i++)
{
    if (i > n)
    {
        break;
    }

    result = (array[i] * array[n]);
    Console.WriteLine($"{array[i]} * {array[n]} = {result}");
    n--;
}