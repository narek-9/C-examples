// Показать числа Фибоначчи

Console.WriteLine("Сколько чисел Фибоначчи нужно напечатать? ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i = 2; i < array.Length; i++)
{
    array[0] = 0;
    array[1] = 1;
    array[i] = array[i - 1] + array[i - 2];
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
