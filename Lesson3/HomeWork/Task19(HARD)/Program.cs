// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой

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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPalindrome(number))
{
    Console.WriteLine("Введенное число является палиндромом.");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом.");
}