// Задайте мвссив из 12 элементов, заполненный случайными числами из промежутка (-9, 9)
// Найдите сумму отрицательных и положительных элементов массива.

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

int[] FindSums(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    foreach (var item in array)
        if (item>0)
            sumP+=item;
        else
            sumN+=item;
    int[] result = {sumN, sumP};
    return result;
}

System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);
FindSums(array);
PrintArray(FindSums(array));
