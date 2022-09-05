// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Enter 3-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void secondDigit()
// {
//     int n1 = num / 10;
//     int n2 = n1 % 10;
    
//     Console.WriteLine("Middle digit is " + n2);
// }
// if(100 > num || num > 999)
//     Console.WriteLine("It's not 3-digit number. Try again!");
// else
// secondDigit();

//или

// Console.WriteLine("Enter 3-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(100 > num || num > 999)
//     Console.WriteLine("It's not 3-digit number. Try again!");
// else
// Console.Write(Convert.ToString(num)[1]);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(100 > num)
//      Console.WriteLine("There is no third digit");
// else
// Console.Write(Convert.ToString(num)[2]);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Enter number from 1 to 7: ");
// int day = Convert.ToInt32(Console.ReadLine());

// void WeekDays()
// {
// if(day == 6 || day == 7)
// Console.WriteLine("It's weekend, yay!");
// else
// Console.WriteLine("It's not weekend, go to work");
// }
// if ( day > 7)
// Console.WriteLine("Wrong! Try again!");
// else
// WeekDays();

//Дополнительная задача. Задана последовательность натуральных чисел, завершающаяся числом 0. 
//Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, 
//который будет наибольшим, если из последовательности удалить наибольший элемент.
//Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
//Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

int[] array = { 1, 2, 3, 4, 5, 6, 7, 0, 8, 9, 0 };
int max1 = array[0];
int max2 = array[1];
int i = 0;
int j = 0;

void MaxNumber1()
{
for (i = 0; i < array.Length; i++)
{
  if (array[i] == 0) break;
  else if(max1 < array[i])
        max1 = array[i];
} 

Console.WriteLine("First maximum " + max1);
}
void MaxNumber2()
{
for(j = 0; j < array.Length; j++)  
{
  if (array[j] == 0) break;
  else if (max2 < array[j] && max1 > max2) 
  max2 = array[j];
}
 Console.WriteLine("Second maximum " + max2);
}
MaxNumber1();
MaxNumber2();