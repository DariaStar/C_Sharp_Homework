// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Eneter number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Eneter number B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int res = 1;

// for (int i = 0; i < B; i++)

//     res *= A;

// Console.WriteLine(res);


//или, если без цикла, но с функцией:

// Console.WriteLine("Eneter number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Eneter number B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// void Exponentiation()
// {
// double res = Math.Pow(A, B);
// Console.WriteLine("A^B=* " + res);
// }

// Exponentiation();


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Enter number with more than 2-digits: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10)
// Console.WriteLine("Number doesn't have 2 digits");

// Console



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
    
 Console.WriteLine("[" + string.Join(", ", array) + "]");
