﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// * 456 -> 46
// * 782 -> 72
// * 918 -> 98
Console.Clear();

int num = new Random().Next(100, 1000);

System.Console.WriteLine($"Было сгенерировано случайное число: {num}");

int x1 = num/100;
int x3 = num%10;

System.Console.WriteLine($"Убираем вторую цифру: {x1}{x3}");