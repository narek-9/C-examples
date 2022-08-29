// Программа проверяет пятизначное число на палиндромом. 

Random rnd = new Random();
int num = rnd.Next(10000, 100000);
Console.WriteLine($"Число = {num}.");
string str = Convert.ToString(num);
string[] array = new string[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = str[i].ToString();
}
if (array[0] == array[4] & array[1] == array[3])
{
    Console.WriteLine($"{num} - палиндром.");
}
else
    Console.WriteLine($"{num} - не палиндром.");

