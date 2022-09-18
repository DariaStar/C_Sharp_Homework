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

// [3,5 7,78 22 2,23 78, 25] -> 76,02

int[] array1 = new int[8];
double[] array2 = new double[8];
double res = 0;
double max = array2[0];
double min = array2[0];

void SetArray1()
{
for (int i = 0; i < array1.Length; i++)
    array1[i] = new Random().Next(100, 1000);

 Console.WriteLine("Set array1: [" + string.Join(", ", array1) + "]");
}

void SetArray2()
{
for (int i = 0; i < array2.Length; i++)
    array2[i] = Convert.ToDouble(array1[i] / 100);

Console.WriteLine("Set array2: [" + string.Join(", ", array2) + "]");

}
void FindMax()
{
 for (int i = 0; i < array2.Length; i++)
    {
    if(array2[i] > max)
    max = array2[i];
    }
Console.WriteLine("max = " + max);
}
void FindMin()
{
for (int i = 0; i < array2.Length; i++)
    {
    if(array2[i] < min)
    min = array2[i];
    }
Console.WriteLine("min = " + min);
}
SetArray1();
SetArray2();
FindMax();
FindMin();
res = max - min;
Console.WriteLine("Difference is " + res);


