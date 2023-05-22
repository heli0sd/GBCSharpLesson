// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Программа поиска всех четных чисел от 1 до N");
Console.Write("Введите положительное число N: ");
double num = Convert.ToInt32 (Console.ReadLine());
int count = 0;

while (count <= num)
    if (count == 0)
        count++;
    else if (count  == 2)
    {
        Console.Write(count);
        count++;
    }
    else if (count % 2 == 0)
    {
        Console.Write(", " + count);
        count++;
    }
    else 
        count++;

