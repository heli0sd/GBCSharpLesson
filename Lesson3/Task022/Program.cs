// Напишите программу, которая на вход принимает число (N)
// и выдает таблицу квадратов чисел от 1 до N

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

void NumberSquare (int x)
{
    int i = 1;
    int sqr = 1;
    while (i <= x)
    {
        sqr = (int)Math.Pow(i, 2);
        Console.Write($"{sqr}, ");
        i++;
    }
}

Console.Write("Введите любое целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
NumberSquare(x);