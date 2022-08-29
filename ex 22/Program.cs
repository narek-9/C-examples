// Найти расстояние между точками в пространстве 2D/3D 

Console.WriteLine("В каком пространстве находятся ваши точки?");
string num = Console.ReadLine();
Console.WriteLine();

if (num == "2D" || num == "2d")
{
    Random rnd = new Random();

    Console.Write("Введите координату x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("x1 = " + Math.Round(x1, 2));
    Console.WriteLine("y1 = " + Math.Round(y1, 2));
    Console.WriteLine("x2 = " + Math.Round(x2, 2));
    Console.WriteLine("y2 = " + Math.Round(y2, 2));
    Console.WriteLine();

    Console.WriteLine("Расстояние между двумя точками в пространстве 2D = " + Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2));
}

if (num == "3D" || num == "3d")
{
    Random rnd = new Random();

    Console.Write("Введите координату x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("x1 = " + Math.Round(x1, 2) + "  ");
    Console.WriteLine("y1 = " + Math.Round(y1, 2) + "  ");
    Console.WriteLine("z1 = " + Math.Round(z1, 2) + "  ");
    Console.WriteLine("x2 = " + Math.Round(x2, 2) + "  ");
    Console.WriteLine("y2 = " + Math.Round(y2, 2) + "  ");
    Console.WriteLine("z2 = " + Math.Round(z2, 2) + "  ");
    Console.WriteLine();

    Console.WriteLine("Расстояние между двумя точками в пространстве 3D = " + Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2));
}

if (num != "2D" & num != "2d" & num != "3D" & num != "3d")
{
    Console.WriteLine("Введите пространство 2D или 3D!");
}