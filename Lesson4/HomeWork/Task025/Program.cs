// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Deg (int num, int deg)
{
    //System.Console.WriteLine(Math.Pow(num, deg));
    int result = 1;
    for (int i = 0; i < deg; i++)
    {
    result = result * num;
    }
    return result;
}

System.Console.WriteLine("Программа для возведения в степень");
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int deg = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Deg(num, deg));