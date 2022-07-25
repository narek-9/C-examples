// Выяснить является ли число чётным

Console.WriteLine("Введите число։ ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} - чётное");
}

else
{
    Console.WriteLine($"Число {num} - нечётное");
}