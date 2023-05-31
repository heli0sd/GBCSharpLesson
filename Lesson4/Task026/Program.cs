// Напишите программу, которая принимает на вход
// Число и выдает количество цифр в числе

int Count (int num)
{
    if(num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    } 
    return count;
}

System.Console.Write("введите целое число любой разрядости: ");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Введенное количество цифр: {Count(num)}");
}
catch (System.Exception)
{
    System.Console.WriteLine("Нужно вводить целое число");
}

