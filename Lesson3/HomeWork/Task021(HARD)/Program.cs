// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.
double[] fillArray (int x)
{
    double[] Array = new double[x];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return Array;
}
System.Console.WriteLine("Программа для поиска длины отрезка в N мерном пространстве");
System.Console.Write("Введиде количество измерений вашего пространства: ");
int Spc = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите через Enter координаты первой точки:");
double[] pointA = fillArray(Spc);
System.Console.WriteLine("Введите через Enter координаты второй точки:");
double[] pointB = fillArray(Spc);
double[] tmp = new double[Spc];
for (int i = 0; i < Spc; i++)
{
    tmp[i] = Math.Pow(pointB[i]-pointA[i], 2);
}
double Sum = 0;
for (int i = 0; i < tmp.Length; i++)
{
     Sum = Sum + tmp[i];
}
System.Console.WriteLine($"Расстояние между укащанными точками {Spc} мерного пространства {Math.Sqrt(Sum)} точек");



