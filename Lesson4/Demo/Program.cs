//Напишите программу котора на вход принимает число А
//и выдает сумму всех чисел от еденицы до A
// int Summa(int num)
// {
//     int result = 0;
//     for (int i =0; i<=num; i++)
//         result+=i;
//     return result;
// }
// Console.Clear();
// System.Console.Write("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {Summa(num)}");
//Enumerable.Range(0,17).Select(v => number * Math.Pow(10, v)).Select((d,i) => new {d , i}).First(x => x.d == (long) x.d).i;
double num = Convert.ToDouble(Console.ReadLine());
int n = Enumerable.Range(0, 17).Select(v => num * Math.Pow(10, v)).Select((d, i) => new {d, i}).First(x => x.d == (long) x.d).i;
System.Console.WriteLine(n);