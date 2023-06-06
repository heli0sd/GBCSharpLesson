
        // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
        void FillArray(int[] array)
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
        void FindNum(int[] array, int num)
        {
            bool Find = false;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (num == array[i])
                {
                    System.Console.WriteLine("Yes");
                    Find = true;
                    break;
                }
            }
            if (Find == false) Console.WriteLine("No");
        }

        Console.Write("Введите размерность массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Введите искомое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        FindNum(array, num);

