// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// * 78 -> 8
// * 12 -> 2
// * 85 -> 8

Console.Clear();

int num = new Random().Next(10, 100);

System.Console.WriteLine($"Было сгенерировано случайное число: {num}");
int x1 = num/10;
int x2 = num%10;

if (x1 > x2)
    System.Console.WriteLine($"Больше цифра этого числа {x1}");
else if (x1 < x2)
    System.Console.WriteLine($"Больше цифра этого числа {x2}");
else
    System.Console.WriteLine("Обе цифры этого числа равны");

for (int i=1;i<=10;i++)
    System.Console.Write($"{i} ");