// int[,] matrix = new int[20, 20];

// for (int i = 0; i < 20; i++)
// {
//     for (int j = 0; j < 20; j++)
//     {
//         System.Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             //Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// int Factorial (int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// System.Console.WriteLine(Factorial(3));

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 0; i < 40; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}

