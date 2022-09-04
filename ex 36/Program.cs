// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Random rnd = new Random();
Console.WriteLine("Введите размер масиива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}

Console.WriteLine("[" + string.Join(", ", array) + "]");

int amountEv = 0;
int amountOdd = 0;
int j = 0;
do
{
    if (array[j] % 2 == 0)
    {
        amountEv++;
    }
    else
    {
        amountOdd++;
    }
    j++;

} while (j < array.Length);

Console.WriteLine($"Количество четных чисел = {amountEv}");
Console.WriteLine($"Количество нечетных чисел = {amountOdd}");
