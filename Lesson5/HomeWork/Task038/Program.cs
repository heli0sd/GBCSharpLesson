// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.;


void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}
int[] FindMinMax (int[] array)
{
    int[] MinMax = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinMax[0])
            MinMax[0] = array[i];
        else if (array[i] > MinMax[1])
            MinMax[1] = array[i];
    }
    return MinMax; 
}
void FindDiff(int[] array)
{
    int x = array[1] - array[0];
    System.Console.WriteLine($"Разница между максимальным и минимальным значениями: {x}");
}

System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);
PrintArray(array);
FindDiff(FindMinMax(array));