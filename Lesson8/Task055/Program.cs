// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для пользователя.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        System.Console.Write($"{array[i,j],3} ");
    System.Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30, 31);
}
int[,] TransArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        if (rowCount != colCount)
        {
            return null;
        }
        int[,] transdArray = new int[rowCount, colCount];
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                transdArray[i, j] = array[j, i];
            }
        }
        return transdArray;
    }
//////////////////////////////////////////////////

Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);

int[,] transArray = TransArray(array);

if (transArray != null)
    {
        Console.WriteLine("Массив со строками и столбцами, замененными местами:");
        PrintArray(transArray);
    }
else
    {
        Console.WriteLine("Невозможно заменить строки на столбцы.");
    }