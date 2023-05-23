// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число крытным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, отстаток 4
// 16, 4 -> кратно
Console.Clear();

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1/num2 == 1)
    System.Console.WriteLine($"Числа равны");
else if (num1/num2 == num1)
    System.Console.WriteLine("Второе число - еденица");
else if (num1%num2 == 0)
    System.Console.WriteLine($"Число {num2} кратно {num1}");
else 
    System.Console.WriteLine("Числа не кратны, остаток " + num1%num2);