// Найти сумму чисел от 1 до А 

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i <= A; i++)
{
    count += i;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {count}");
