// Задача 49: Задайте двумерный массив. Найдите элементыб у которых
// оба индекса четные, и замените эти элементы на их квадраты

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-9, 9);
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
void ReplaceArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            {
            if (i%2 != 0 && j%2 != 0)
                array[i,j] = (int) Math.Pow(array[i, j], 2);
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
System.Console.WriteLine();
ReplaceArray(array);
PrintArray(array);