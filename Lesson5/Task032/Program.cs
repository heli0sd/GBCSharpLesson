// Напишите программу, замена элементов массива:
// Положительные элементы массива замените на соответствующие отрицательные и наоборот

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 21);
    }   
}

void RepArray (int[] array)
{
   int Pos = 0;
   int Neg = 0;
   for (int i = 0; i < array.Length; i++)
   {
     if (array[i] < 0)
        array[i] *= -1; 
   } 
   
}

System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];