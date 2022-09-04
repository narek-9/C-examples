// Написать программу замену элементов массива на противоположные

Console.WriteLine("Введите размер масиива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения масиива: ");
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
