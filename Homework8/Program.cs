// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07