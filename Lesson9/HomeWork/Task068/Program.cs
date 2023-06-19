﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman (int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return Akkerman(M-1, 1);
    return Akkerman(M-1, Akkerman(M,N-1));
}
Console.Clear();
System.Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{Akkerman(M, N)}");