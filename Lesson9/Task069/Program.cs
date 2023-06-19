// На вход берем числа А и B, и возводим число А в степень B (При помощи рекурсии)
int Stepen (int A, int B)
{
    if (B == 0) return 1;
    return A * Stepen(A, B-1);
}

Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Степень {Stepen(A,B)}");