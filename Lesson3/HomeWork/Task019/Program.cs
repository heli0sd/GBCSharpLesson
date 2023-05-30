// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reverseNumber = (reverseNumber * 10) + digit;
            number /= 10;
        }
        return originalNumber == reverseNumber;
    }

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPalindrome(number))
{
    Console.WriteLine("Введенное число является палиндромом.");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом.");
}



