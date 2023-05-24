// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Поиск второй цифры трехзначного числа");
int num = Convert.ToInt32(Console.ReadLine());
int x =(int)Math.Log10(num) + 1;

do {
    if (x == 2)
     {
             Console.WriteLine($"Вторая цифра {num%10}");
             x--;
     }
     else if (x > 2)
     {
        x--;
        num = num/10;
     }
     else
     {
         Console.WriteLine("Нет второй цифры числа");
     }
}
 while (x >= 2);    