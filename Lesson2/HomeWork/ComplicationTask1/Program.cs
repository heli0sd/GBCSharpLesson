// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

System.Console.WriteLine("Введите любое число");
 Console.Write("Введите число N: ");
 double n = Convert.ToDouble (Console.ReadLine());

double a = Math.trunc(n); // int
double ax = a.toString().length;  // length int
double a1 = Math.floor( n / (Math.pow(10, ax-1)) ) %10; // 1st digit
double a2 = Math.floor( n / (Math.pow(10, ax-2)) ) %10; // 2nd digit

if (ax>1) 
{
    tt2 = n - a2 * Math.pow(10, ax-2) - a1*9*Math.pow(10, ax-2);
} 
else 
{
    tt2 = Math.trunc(n);
}
