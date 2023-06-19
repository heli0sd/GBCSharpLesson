// Посчитать сумму всех целых чисел от 1 до N, где N вводит пользователь

int Summa(int num)
{
    int sum = 0;
    while (true)
    {
        sum+=num;
        num--;
        if (num == 0)
            break;
    }
    return sum;
}

int SummaRec(int num)
{
    if (num == 0) return 0;
    return num + SummaRec(num-1);
}

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма всех целых чисел от 1 до {num} равна {Summa(num)}");
System.Console.WriteLine($"Рекурсия {SummaRec(num)}");

