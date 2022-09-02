// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
string[] array = new string[str.Length];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = str[i].ToString();
}
for (int i = 0; i < array.Length; i++)
{
    count = count + Convert.ToInt32(array[i]);
}

Console.WriteLine($"Сумма цифр числа {num} = {count}");







