// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координату x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 & y > 0)
    Console.WriteLine("Точка находится в 1-ой четверти плоскости.");

if (x < 0 & y > 0)
    Console.WriteLine("Точка находится во 2-ой четверти плоскости.");

if (x < 0 & y < 0)
    Console.WriteLine("Точка находится в 3-ей четверти плоскости.");

if (x > 0 & y < 0)
    Console.WriteLine("Точка находится в 4-ой четверти плоскости.");

if (x == 0 || y == 0)
    Console.WriteLine("Ни одна координата не должна быть = 0.");
