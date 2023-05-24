// Напишите программу, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого

// 5, 25 да 
// -4, 16 да 
// 25,5 да
// 8,9 нет

Console.Write("Введите целое число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int dnum1 = num1 * num1;
int dnum2 = num2 * num2;

if (dnum1 == num2 || dnum2 == num1)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");