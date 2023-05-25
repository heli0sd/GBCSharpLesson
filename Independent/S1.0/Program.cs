//Вывести на экран случайное число с точностью до сотых.

System.Console.WriteLine("Программа генерирует случайное число, и выводит его с точностью до сотых");
//Генерируем соучайное числоэ
double n = new Random().NextDouble();

System.Console.WriteLine(Math.Round(n, 2));
