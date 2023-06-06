// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//функция заполнения массива случайными 3х значными числами
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
//Выводим массив на экран
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}
//Считаем количество четных чисел
void Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
            count++;
    }
    System.Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);
PrintArray(array);
Count(array);
