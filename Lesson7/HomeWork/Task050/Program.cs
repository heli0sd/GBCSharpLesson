// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
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
void FindArray(int[,] array, int Value)
{
bool found = false;
int targetRow = -1;
int targetColumn = -1;

for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == Value)
                {
                    found = true;
                    targetRow = i;
                    targetColumn = j;
                    break;
                }
        }
    }
        if (found)
        {
            Console.WriteLine($"Значение {Value} найдено в позиции ({targetRow}, {targetColumn}).");
        }
        else
        {
            Console.WriteLine($"Значение {Value} не найдено в массиве.");
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
Console.Write("Введите значение элемента: ");
int Value = Convert.ToInt32(Console.ReadLine());
FindArray(array, Value);


