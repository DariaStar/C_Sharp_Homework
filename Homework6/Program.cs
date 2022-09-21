// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Enter number ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int count = 0;

// void FillArray()
// {
// for(int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(-99, 100);
// Console.WriteLine("Array [" + string.Join(", ", array) + "]");
// }

// void MoreThanZero()
// {
// for(int i = 0; i < array.Length; i++)
// {
// if(array[i] > 0)
// count++;
// }
// Console.WriteLine(count + " times");
// }
// FillArray();
// MoreThanZero();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Enter b1 ");
// double b1 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Enter k1 ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter b2 ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter k2 ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);   //k1 * x + b1 = k2 * x + b2
//                                     //k1 * x = k2 * x + b2 - b1
//                                     //k1 * x - k2 *  x = b2 - b1
//                                     //(k1 - k2) x = b2 - b1
// double y = k1 * x + b1;

// Console.WriteLine("x = " + x + " y = " + y);

//Задача 1236. Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
//Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы.
//В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

//тут что-то не до конца у меня работает

// Console.WriteLine("Enter rows ");
// int r = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Enter columns ");
// int c = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[r, c];
// int aux = 0;

// void FillMatrix(int[,] matrix)
// {
// for(int row = 0; row < r; row++)
// {
//     for(int col = 0; col < c; col++)
//     {
//     matrix[row, col] = new Random().Next(1,10);
//     Console.Write($"{matrix[row, col]}");
//     }
// Console.WriteLine();
// }
// }

// void Trans(int[,] matrix)
// {
// for(int row = 0; row <= r / 2; row++)
// {
//     for(int col = 0; col < c; col++)
//     {
//     aux = matrix[row, col];
//     matrix[row, col] = matrix [c - 1 - row, col];
//     matrix[c - 1 - row, col] = aux;
//     }
// }
// }

// void PrintMatrix(int[,] matrix)
// {
// for(int row = 0; row < r; row++)
// {
//     for(int col = 0; col < c; col++)
//     Console.Write($"{matrix[row, col]}");
// Console.WriteLine();
// }
// }
// FillMatrix(matrix);
// Trans(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

//Задача 351. Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

string[] symbols = {o, x, i};

void Print()

    Console.WriteLine()