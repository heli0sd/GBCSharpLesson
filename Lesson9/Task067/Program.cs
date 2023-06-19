// На вход принимаем число и возвращаем сумму его цифр (При помощи рекурсии)

int Summ (int num)
{
    if (num == 0) return 0;
    return num%10 + Summ(num/10);
}

Console.Clear();
Console.Write("Введите целое многозначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summ(num));