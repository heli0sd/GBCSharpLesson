// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке 10 - 99
// 1:10:27 

void NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 201);
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
void Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99 )
            count++;
    }
    System.Console.WriteLine($"Количество соответствующих элементов: {count}");
}
System.Console.WriteLine("Создаем массив из 123 элементов");
int[] array = new int[123];
NewArray (array);
PrintArray(array);
System.Console.WriteLine("Считаем количество элементов от 10 до 99");
Count(array);



