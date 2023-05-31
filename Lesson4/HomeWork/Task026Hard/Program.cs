// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе. Строки использовать нельзя
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        double number;
        bool isNumber = double.TryParse(Console.ReadLine(), out number);

        if (isNumber)
        {
            int count = CountDigits(number);
            Console.WriteLine("Количество цифр в числе: " + count);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }

    static int CountDigits(double number)
    {
        long integerPart = (long)Math.Abs(number);
        int integerPartCount = CountDigits(integerPart);

        double fractionalPart = Math.Abs(number - Math.Truncate(number));
        int fractionalPartCount = CountDigits(fractionalPart, true);

        return integerPartCount + fractionalPartCount;
    }

    static int CountDigits(long number)
    {
        if (number == 0)
        {
            return 1;
        }

        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    static int CountDigits(double number, bool isFractionalPart)
    {
        if (number == 0)
        {
            return 1;
        }

        int count = 0;
        double epsilon = 1e-10;

        while (Math.Abs(number - Math.Round(number)) > epsilon)
        {
            number *= 10;
            count++;
        }

        if (isFractionalPart)
        {
            count++; // Учитываем точку
        }

        return count;
    }
}