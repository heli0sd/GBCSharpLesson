// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void NewArr ()
{
int[] Arr = new int[8];
for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(0, 1000);
        System.Console.Write($"{Arr[i]} ");
    }
}    

NewArr();