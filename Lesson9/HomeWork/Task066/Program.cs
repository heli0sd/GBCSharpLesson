// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. При помощи рекурсии
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int M, int N)
{
    if (M > N) return 0;
    return M + Summ(M+1,N);
}

Console.Clear();
System.Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{Summ(M, N)}");
