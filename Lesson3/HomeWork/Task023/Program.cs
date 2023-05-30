// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void NumberSquare (int x)
{
    int i = 1;
    int sqr = 1;
    while (i <= x)
    {
        sqr = (int)Math.Pow(i, 3);
        Console.Write($"{sqr}, ");
        i++;
    }
}

Console.Write("Введите любое целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
NumberSquare(x);