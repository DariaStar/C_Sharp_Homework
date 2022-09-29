// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

// int[,] matrix = new int[4, 4];

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         matrix[i, j] = new Random().Next(1, 10);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write(matrix[i, j] + " \t");
//         Console.WriteLine();
//     }
// }

// int[,] OrderMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             int maxEl = matrix[i, j];
//             int maxJ = j;
//                  for (int k = j + 1; k < matrix.GetLength(1); k++)
//                  {
//                      if (matrix[i, k] > maxEl)
//                      {
//                          maxEl = matrix[i, k];
//                          maxJ = k;
//                      }
//                  }
//             int aux = matrix[i, j];
//             matrix[i, j] = matrix[i, maxJ];
//             matrix[i, maxJ] = aux;
//         }
//     }
//     return matrix;
// }

// InputMatrix(matrix);
// PrintMatrix(matrix);
// PrintMatrix(OrderMatrix(matrix));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

// int[,] matrix = new int[4, 4];
// int sum = 0;
// int minSum = 1000;

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         matrix[i, j] = new Random().Next(1, 10);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write(matrix[i, j] + " \t");
//         Console.WriteLine();
//     }
// }

// void Sum(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum = 0;
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             sum += matrix[i, j];    
//     Console.WriteLine($"Sum of the {i} line is " + sum);
//     if(sum < minSum)
//     minSum = sum;
//     }
// Console.WriteLine("Min sum is " + minSum);
// }


// InputMatrix(matrix);
// PrintMatrix(matrix);
// Sum(matrix);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] matrix1 = new int [2, 2];
// int[,] matrix2 = new int [2, 2];
// int[,] matrix3 = new int [2, 2];

// void InputMatrix(int[,] matrix1)
// {
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         matrix1[i, j] = new Random().Next(1, 10);
//     }
// }

// void PrintMatrix(int[,] matrix1)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         Console.Write(matrix1[i, j] + " \t");
//         Console.WriteLine();
//     }
// }

// void SumMatrix(int[,] matrix1, int[,] matrix2)
// {
//  for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
        
//     }   
// }

// InputMatrix(matrix1);
// PrintMatrix(matrix1);
// InputMatrix(matrix2);
// PrintMatrix(matrix2);
// SumMatrix(matrix1, matrix2);
// PrintMatrix(matrix3);

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// void InputMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             matrix[i, j, k] = new Random().Next(10, 100);
//         }
//     }
// }

// void PrintMatrix(int[,,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             Console.Write(matrix[i, j, k] + $"({i}, {j}, {k})"  + " \t");
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] matrix = new int[2, 2, 2];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Задача 62. НЕ ПОЛУЧИЛАСЬ. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//НЕ ПОЛУЧИЛАСЬ

// int[,] matrix = new int[4, 4];
// int k = 0;
// int r = 0;
// int c = 0;

// int[,] Spiral(int[,] matrix)
// {
// for (c = 0; c < matrix.GetLength(1); c++)
//      matrix[r, c] = k++;
        
// for (r = 1; r < matrix.GetLength(0); r++)
// {
//     c = 0;
//     matrix[r, c] = k++;
// }

// for (c = matrix.GetLength(1) - 1; c == 0; c--)
// {
//     r = 0;
//     matrix[r, c] = k++;
// }
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.Write(matrix[r, c] + " \t");
//         Console.WriteLine();

//     }
// }
// Spiral(matrix);
// PrintMatrix(matrix);
