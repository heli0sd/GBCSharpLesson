// Напишите программу, замена элементов массива:
// Положительные элементы массива замените на соответствующие отрицательные и наоборот

// int x = -20;
// int y = ~x;
// y += 1; 
// System.Console.WriteLine(y);
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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
void ReplaiceArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ~array[i] + 1;
    }
}

Console.Clear();
Console.WriteLine("Программа создает массив заданной размерности, заполняет его случайными числами от -100 до 100");
Console.WriteLine("Затем меняет в нем положительные элементы на отрицательные и наоборот, выводит на экран");
Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);
ReplaiceArray(array);
PrintArray(array);

