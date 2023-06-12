// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
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
void SortArray(int[,] array, int rows, int columns)
{
// Преобразование двумерного массива в одномерный для сортировки
int[] flattenedArray = new int[rows * columns];
int index = 0;
for (int i = 0; i < rows; i++)
    {
    for (int j = 0; j < columns; j++)
        {
            flattenedArray[index++] = array[i, j];
        }
    }
// Сортировка одномерного массива
Array.Sort(flattenedArray);
// Преобразование отсортированного одномерного массива обратно в двумерный массив
index = 0;
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = flattenedArray[index++];
        }
    }
// Вывод отсортированного массива
Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
SortArray(array, rows, columns);

