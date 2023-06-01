// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе. Строки использовать нельзя
// 456 -> 3
// 0 -> 1
//89,126 -> 5
// 0,001->4
//Enumerable.Range(0,10).Select(v => number * Math.Pow(10, v)).Select((d,i) => new {d , i}).First(x => x.d == (long) x.d).i;
Console.Write("Введите число: ");
double number;
bool isNumber = double.TryParse(Console.ReadLine(), out number);
int BefCo = (int)Math.Log10(number) + 1;
int AftCo = Enumerable.Range(0,17).Select(v => number * Math.Pow(10, v)).Select((d,i) => new {d , i}).First(x => x.d == (long) x.d).i;

int result = BefCo + AftCo;
System.Console.WriteLine(result);