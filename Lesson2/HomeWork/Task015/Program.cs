// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
    System.Console.WriteLine("Этот день выходной");
else if (num < 1 || num > 7)
    System.Console.WriteLine("В неделе только 7 дней");
else 
    System.Console.WriteLine("Этот день рабочий");