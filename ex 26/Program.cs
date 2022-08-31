// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число A: ");
int B = Convert.ToInt32(Console.ReadLine());

int count = 1;

for (int i = 0; i < B; i++)
{
    count *= A;
}

Console.WriteLine($"Число {A} в степени {B} = {count}");