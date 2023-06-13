// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] CreateArray(int rows, int cols, int zet)
    {
        int[,,] array = new int[rows, cols, zet];
        int number = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = number++;
                }
            }
        }
        return array;
    }
static void PrintArray(int[,,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int zet = array.GetLength(2);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < zet; k++)
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }

Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите глубину массива: ");
int zet = Convert.ToInt32(Console.ReadLine());

int[,,] array = CreateArray(rows, cols, zet);
PrintArray(array);



