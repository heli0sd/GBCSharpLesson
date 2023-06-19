// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N


string GetNum(int num1, int num2)
{
    string str = "";
    while (true)
    {
        str = num2 + " " + str;
        num2--;
        if (num2 == num1-1)
            break;
    }
    return str;
}

string GetNumRec(int num1, int num2)
{
    if (num2 == num1) return "";
    return num1 + + GetNumRec(num1, num2-1) + " " + num2;
}

System.Console.Write("Введите целое число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите целое число M: ");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{GetNum(num1, num2)}");
System.Console.WriteLine($"{GetNumRec(num1, num2)}");