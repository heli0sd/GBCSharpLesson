// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива, возможно придется кое-что для этого дополнительно выполнить.

 // Создаем случайный массив из 10 целых чисел от 1 до 100
int[] array = new int[10];
Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
// Находим максимальный и минимальный элементы и их индексы
int maxElement = array.Max();
int minElement = array.Min();
int maxIndex = Array.IndexOf(array, maxElement);
int minIndex = Array.IndexOf(array, minElement);
// Вычисляем среднее арифметическое всех элементов
double mean = array.Average();
// Находим медиану первоначального массива
Array.Sort(array);
double median;
    if (array.Length % 2 == 0)
        {
            median = (array[array.Length / 2 - 1] + array[array.Length / 2]) / 2.0;
        }
    else
        {
            median = array[array.Length / 2];
        }
// Создаем новый массив с результатами
object[] resultArray = new object[] { maxElement, maxIndex, minElement, minIndex, mean, median };
// Выводим результаты на экран
Console.WriteLine("Максимальный элемент: " + resultArray[0]);
Console.WriteLine("Индекс максимального элемента: " + resultArray[1]);
Console.WriteLine("Минимальный элемент: " + resultArray[2]);
Console.WriteLine("Индекс минимального элемента: " + resultArray[3]);
Console.WriteLine("Среднее арифметическое: " + resultArray[4]);
Console.WriteLine("Медиана: " + resultArray[5]);
