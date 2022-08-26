// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
    Console.WriteLine("Диапазон 1-ой четверти: x > 0 и y > 0.");
if (number == 2)
    Console.WriteLine("Диапазон 2-ой четверти: x < 0 и y > 0.");
if (number == 3)
    Console.WriteLine("Диапазон 3-ой четверти: x < 0 и y < 0.");
if (number == 4)
    Console.WriteLine("Диапазон 4-ой четверти: x > 0 и y < 0.");
if (number < 1 | number > 4)
    Console.WriteLine("Такой четверти нет!");