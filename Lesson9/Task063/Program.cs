// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N

string GetNum(int num)
{
    string str = "";
    while (true)
    {
        str = num + " " + str;
        num--;
        if (num == 0)
            break;
    }
    return str;
}

string GetNumRec(int num)
{
    if (num == 0) return "";
    return GetNumRec(num-1) + " " + num;
}

System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{GetNum(num)}");
System.Console.WriteLine($"{GetNumRec(num)}");