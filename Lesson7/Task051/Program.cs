// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// Находящихся на главной диагонали(с индексами 0:0 1:1 и т.д)
// И найдите сумму элементов обратной диагонали.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1, 5);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        System.Console.Write($"{array[i,j],3} ");
    System.Console.WriteLine();
    }
}

void TraceArray(int[,] array)
{
    int num1 = 0;
    int num2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                num1 = num1 + array[i,j];
            else if (i == array.GetLength(1)-j-1)
                num2 = num2 + array[i,j];
        }
    System.Console.WriteLine($"{num1}, {num2}" );
}

Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
TraceArray(array);

