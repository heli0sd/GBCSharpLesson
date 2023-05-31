// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sum (int num)
{if (num >= -9 && num <= 9)
    Console.WriteLine($"Вы ввели только одну цифру: {num}. Суммировать нечего");
else
    {
       int count = (int)Math.Log10(num)+1;
       int result = 0;
       for (int i = 0; i < count; i++)
       {
            result = result + num%10;
            num = num/10;
       }
        System.Console.WriteLine($"Результат суммирования всех чисел числа: {result}");
    }
}
System.Console.WriteLine("Программа для суммирования всех цифр введенного многозначного числа");
System.Console.Write("Введите целое многозначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Sum(num);



