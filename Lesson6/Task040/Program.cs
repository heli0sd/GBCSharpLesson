// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о не равенстве треугольника. Каждая сторона меньше суммы двух других сторон.
bool Res (double x, double y, double z)
{
    bool flag = false;
    if (x < z + y && z < x + y && y < z + x)
        {
            flag = true;
        }
    return flag;
}

Console.WriteLine("Введите последовательно 3 числа: ");
double x = Convert.ToInt32(Console.ReadLine());
double y = Convert.ToInt32(Console.ReadLine());
double z = Convert.ToInt32(Console.ReadLine());

if (Res(x, y, z))
{
    System.Console.WriteLine("Постоить можно");
}
else
    System.Console.WriteLine("Построить нельзя");
