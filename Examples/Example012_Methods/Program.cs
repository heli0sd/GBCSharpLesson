// // Вид 1
// void Method1()
// {
//     System.Console.WriteLine("Автор: Вася Пупкин");
// }

// //Вызов

// Method1();

// Вид 2

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method2("Текст сообщения", 10);

//Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();

// System.Console.WriteLine(year);

//Вид 4

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qw ");
// Console.WriteLine(res);

// string Method4 (int count, string text)
// {
    
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "qw ");
// Console.WriteLine(res);

