// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write( "Введите координату a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write( "Введите координату a1: ");
double a1 = Convert.ToDouble(Console.ReadLine());

Console.Write( "Введите координату b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write( "Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write( "Введите координату c: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write( "Введите координату c1: ");
double c1 = Convert.ToDouble(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(a1 - a,2) + Math.Pow(b1-b,2) + Math.Pow(c1-1,2));

Console.WriteLine($"Расстояние между точками = {x = Math.Round(x,2)} ");
