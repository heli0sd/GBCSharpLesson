// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Функция заполнения массива случайными элементами
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30, 31); 
}
//Функция вывода массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        System.Console.Write($"{array[i,j],3} ");
    System.Console.WriteLine();
    }
}
//Функция сортировки строк массива по убыванию
void SortRowsDescending(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        for (int i = 0; i < rowCount; i++)
        {
            int[] row = new int[colCount];
            for (int j = 0; j < colCount; j++)
            {
                row[j] = array[i, j];
            }
            Array.Sort(row, (x, y) => y.CompareTo(x));
            for (int j = 0; j < colCount; j++)
            {
                array[i, j] = row[j];
            }
        }
    }


Console.Clear();

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SortRowsDescending(array);
PrintArray(array);