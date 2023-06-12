// Не используя рекурсию, выведете первые N чисел Фиббоначи. Первые 2 числа Фибрначи 0 и 1.

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
System.Console.WriteLine("Введите : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);
PrintArray(array);
