//Напишите программу котора на вход принимает число А
//и выдает сумму всех чисел от еденицы до A

int Summa(int num)
{
    int result = 0;
    for (int i =0; i<=num; i++)
        result+=i;
    return result;
}

Console.Clear();
System.Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {Summa(num)}");

