// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30, 31);
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
void columnAverages(int[,] array)
{
    double[] columnAverages = new double[array.GetLength(1)];
    for (int j = 0; j <array.GetLength(1); j++)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double)sum / array.GetLength(0);
        }
    for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {columnAverages[j]:F1}");
        }
}
Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
columnAverages(array);