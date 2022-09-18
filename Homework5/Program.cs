// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int count = 0;
// int[] array = new int [10];

// void SetArray()
// {
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 1000);

//  Console.WriteLine("Set array: [" + string.Join(", ", array) + "]");
// }

// void EvenNumbers()
// {
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//         count++;
// }
// SetArray();
// EvenNumbers();
// Console.WriteLine(count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int [8];
// int sum = 0;

// void SetArray()
// {
// for (int i = 1; i < array.Length; i++)
//     array[i] = new Random().Next(-9, 10);
//     Console.WriteLine("Set array: [" + string.Join(", ", array) + "]");
// }
// void Sum()
// {
// for (int i = 1; i < array.Length; i++)
//     if (i % 2 == 1)
//     sum = sum + array[i];
// }
// SetArray();
// Sum();
// Console.WriteLine("Sum is: " + sum);

// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[8];
// double res = 0;
// double max = 0;
// double min = 1000;

// void SetArray()
// {
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 1000) + new Random().NextDouble();
//  Console.WriteLine("Set array: [" + string.Join(", ", array) + "]");
// }

// void FindMax()
// {
//  for (int i = 0; i < array.Length; i++)
//     {
//     if(array[i] > max)
//     max = array[i];
//     }
// Console.WriteLine("max = " + max);
// }
// void FindMin()
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//     if(array[i] < min)
//     min = array[i];
//     }
// Console.WriteLine("min = " + min);
// }
// SetArray();
// FindMax();
// FindMin();
// res = max - min;
// Console.WriteLine("Difference is " + res);
