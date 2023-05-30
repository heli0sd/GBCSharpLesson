//Напишите программу которая на вход принимает координаты точки (X и Y), 
//причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости
//в которой находится эта точка

void CheckKoord(int x, int y)
{
if (x > 0 && y > 0)
    System.Console.WriteLine("Это четверть №1");
else if (x > 0 && y < 0)
    System.Console.WriteLine("Это четверть №4");
else if (x < 0 && y > 0)
    System.Console.WriteLine("Это четверть №2");
else if (x < 0 && y < 0)
    System.Console.WriteLine("Это четверть №3");
else 
    System.Console.WriteLine("Точка находится на координатной оси");
}

Console.Clear();
Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x, y);
