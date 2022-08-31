// Определить количество цифр в числе

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);
string[] array = new string[str.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = str[i].ToString();
}
Console.WriteLine($"Количество цифр в числе {num} = {array.Length}");
// Console.WriteLine("[" + string.Join(", ", array) + "]");