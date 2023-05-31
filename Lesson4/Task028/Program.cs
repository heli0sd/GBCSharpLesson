// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N

double Fact (double num)
{
    double result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

System.Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());


System.Console.WriteLine(Fact(num));