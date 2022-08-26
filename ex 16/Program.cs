// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной.");
}

if (num < 6 & num > 0)
{
    Console.WriteLine("Это рабочий день.");
}

if (num < 1 || num > 7)
{
    Console.WriteLine("Такого дня недели нет!");
}