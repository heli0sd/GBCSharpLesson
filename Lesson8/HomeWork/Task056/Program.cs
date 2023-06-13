// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Функция для заполнения массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-10, 11);
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
//Функция для поиска строки с минимальной суммой элементов
static int FindRowMinSum(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int minRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rowCount; i++)
        {
            int sum = 0;
            for (int j = 0; j < colCount; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minRow = i;
            }
        }

        return minRow;
    }

Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);

int minSum = FindRowMinSum(array);

System.Console.WriteLine($"Номер строки с минимальной суммой элементов {minSum}");