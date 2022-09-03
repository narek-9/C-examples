// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

Random rnd = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 2);
}

Console.WriteLine("[" + string.Join(", ", array) + "]");