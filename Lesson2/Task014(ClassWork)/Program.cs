// Напишите программу, которая принимает на вход число и проверяет кратно ли оно, одновременно 7 и 23
// 14 -> No
// 46 -> No
// 161 - Yes
Console.Clear();
Console.Write("введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine($"{num} кратно 7 и 23");
else
    Console.WriteLine($"{num} не кратно 7 и 23");