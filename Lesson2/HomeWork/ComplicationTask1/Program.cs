// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

System.Console.WriteLine("Введите любое число");
 Console.Write("Введите число N: ");
double n = Convert.ToDouble (Console.ReadLine());

double a = Math.Truncate(n); // int
double az = (int)Math.Log10(a) + 1;  
double ax = Convert.ToDouble(az);
double a1 = Math.Floor( n / (Math.Pow(10, ax-1)) ) %10; // 1st digit
double a2 = Math.Floor( n / (Math.Pow(10, ax-2)) ) %10; // 2nd digit
double tt2 = 0;

if (ax>1) 
{
    tt2 = n - a2 * Math.Pow(10, ax-2) - a1*9*Math.Pow(10, ax-2);
} 
else 
{
    tt2 = Math.Truncate(n);
}

System.Console.WriteLine(Math.Round(tt2, 9));