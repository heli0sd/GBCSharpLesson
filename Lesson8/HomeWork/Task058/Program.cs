// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0, 5);
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        int[,] product = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                product[i, j] = sum;
            }
        }

        return product;
    }

/////////////////////////
Console.Clear();
System.Console.Write("Введите количество строк первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов первой матрицы: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[rows, cols];
System.Console.Write("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов второй матрицы: ");
int cols2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[rows, cols];
FillArray(matrix1);
FillArray(matrix2);

PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();
int[,] product = MultiplyMatrix( matrix1, matrix2);
PrintArray(product);