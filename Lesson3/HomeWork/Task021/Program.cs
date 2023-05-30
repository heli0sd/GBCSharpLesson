// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void CutLength (double xa, double ya, double za, double xb, double yb, double zb)
{
    double len = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    System.Console.WriteLine($"Длина отрезка: {len}");
}
System.Console.WriteLine("Программа для нахождения длины отрезка на плоскости.");
Console.Write("Введите координату 'x' первой точки: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'y' первой точки: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'z' первой точки: ");
double za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'x' второй точки: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'y' второй точки: ");
double yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'z' второй точки: ");
double zb = Convert.ToInt32(Console.ReadLine());

CutLength(xa, ya, za, xb, yb, zb);