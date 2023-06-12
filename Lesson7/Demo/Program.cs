// Задача 46: Задайте двумерный массив размером rows cols, заполненный случайными целыми числами.

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
Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);