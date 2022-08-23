// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Random rnd = new Random();

int number = rnd.Next(10, 100);
int[] array = new int[2];

array[0] = number / 10;
array[1] = number % 10;

Console.WriteLine($"Исходное число = {number}.");

if (array[0] > array[1])
    Console.WriteLine($"Наибольшая цифра = {array[0]}");

else
    Console.WriteLine($"Наибольшая цифра = {array[1]}.");
