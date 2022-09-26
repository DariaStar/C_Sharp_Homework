// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[m, n];

// void FillMatrix(double[,] matrix)
// {
// for(int row = 0; row < m; row++)
// {
//     for(int col = 0; col < n; col++)
//     {
//     matrix[row, col] = new Random().Next(-10, 10) + new Random().NextDouble();
//     Console.Write($"{matrix[row, col]}" + " \t");
//     }
// Console.WriteLine();
// }
// }

// FillMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Console.WriteLine("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void FillMatrix(int[,] matrix)
// {
// for(int row = 0; row < m; row++)
// {
//     for(int col = 0; col < n; col++)
//     {
//     matrix[row, col] = new Random().Next(1,10);
//     Console.Write($"{matrix[row, col]}" + " \t");
//     }
// Console.WriteLine();
// }
// }

// void Element(int[,] matrix)
// {
//     Console.Write("Enter row: ");
//     int r = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Enter column: ");
//     int c = Convert.ToInt32(Console.ReadLine());

//     if (r > matrix.GetLength(0) - 1 || c > matrix.GetLength(1) - 1)
//         Console.WriteLine("No such element");
//     else
//         Console.WriteLine($"It is {matrix[r, c]}");
// }

// int[,] matrix = new int[m, n];
// FillMatrix(matrix);
// Element(matrix);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];

// void FillMatrix(int[,] matrix)
// {
// for(int row = 0; row < m; row++)
// {
//     for(int col = 0; col < n; col++)
//     {
//     matrix[row, col] = new Random().Next(1,10);
//     Console.Write($"{matrix[row, col]}" + " \t");
//     }
// Console.WriteLine();
// }
// }

// void MeanInRow(int[,] matrix)
// {
//     for (int c = 0; c < matrix.GetLength(1); c++)
//     {
//         double sum = 0;
//         for (int r = 0; r < matrix.GetLength(0); r++)
//         {
//             sum += matrix[r, c];
//         }
//         Console.WriteLine($"Mean {c} is {sum / matrix.GetLength(0)}");
//     }
// }

// FillMatrix(matrix);
// MeanInRow(matrix);

