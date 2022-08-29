// Найти третью цифру числа или сообщить, что её нет\

Random rnd = new Random();
int num = rnd.Next(0, 100000);
Console.WriteLine($"Число = {num}.");

string str = num.ToString();
string[] array = new string[str.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = str[i].ToString();
}

if (array.Length >= 3)
    Console.WriteLine($"Третья цифра числа = {array[2]}.");
else
    Console.WriteLine("Третьей цифры нет.");

