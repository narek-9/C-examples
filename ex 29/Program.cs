// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int N1 = N;
int result = 1;
do
{
    result = result * N;
    N--;
} while (N != 0);

Console.WriteLine($"Произведение чисел от 1 до {N1} = {result}");
