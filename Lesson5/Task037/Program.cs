// Найдите произведение пар чисел в одном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

//Функция заполнения массива, случайными числами
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }    
}
//Функция вывода массива на экран
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

Console.Clear(); // Очищаем консоль
int size = 5;//new Random().Next(5, 100); //Задаем случайный размер массива от 5 до 99
int[] array = new int[size]; //Создаем массив с заданным размером, заполненный нулями (Пустой)
FillArray(array); //Вызываем функцию заполнения архива
PrintArray(array); //выводим полученный массив на экран

int FirstIndex = 0;
int EndIndex = array.Length;
int[] NewArray = new int[0];
int index = 0;
while (FirstIndex < EndIndex)
{
    NewArray[index] = array[FirstIndex] * array[EndIndex]; 
    index++;
    FirstIndex++;
    EndIndex--;
}
