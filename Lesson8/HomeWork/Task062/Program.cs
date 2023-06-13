// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/////////////////////////////////////////////////////////////////////////////////
void PigTail(int[,] array, int size)
{
int value = 1;
int n = size;

int rowStart = 0, rowEnd = n - 1;
int colStart = 0, colEnd = n - 1;

while (value <= n * n)
    {
    // Заполняем верхнюю строку
    for (int col = colStart; col <= colEnd; col++)
        {
            array[rowStart, col] = value++;
        }
    rowStart++;
    // Заполняем правый столбец
    for (int row = rowStart; row <= rowEnd; row++)
        {
            array[row, colEnd] = value++;
        }
        colEnd--;
    // Заполняем нижнюю строку
    for (int col = colEnd; col >= colStart; col--)
        {
            array[rowEnd, col] = value++;
        }
        rowEnd--;
    // Заполняем левый столбец
    for (int row = rowEnd; row >= rowStart; row--)
        {
            array[row, colStart] = value++;
        }
        colStart++;
    }
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


//Создаем массив.
Console.Write("Введите размер стороны массива (массив квадратный): "); 
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];

PigTail(array, size);
PrintArray(array);