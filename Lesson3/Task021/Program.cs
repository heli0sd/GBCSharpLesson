//Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21

//Match.Sqrt
//Формула нахождения расстояния между точками.

//AB = √(xb - xa)2 + (yb - ya)2
//          a2           b2
void CutLength (double xa, double ya, double xb, double yb)
{
    double len = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
    System.Console.WriteLine($"Длина отрезка: {len}");
}
System.Console.WriteLine("Программа для нахождения длины отрезка на плоскости.");
Console.Write("Введите координату 'x' первой точки: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'y' первой точки: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'x' второй точки: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'y' второй точки: ");
double yb = Convert.ToInt32(Console.ReadLine());

CutLength(xa, ya, xb, yb);