﻿// Показать четные числа от 1 до N

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.Write($"{i}, ");
    i++;
}