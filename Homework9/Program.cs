// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int Sum (int n, int m)
// {
//     if (n == m)
//         return n;
//     return Sum(n - 1, m) + n;
// }
// int m = new Random().Next(1,10);
// Console.WriteLine("M is " + m);
// int n = new Random().Next(1,10);
// Console.WriteLine("N is " + n);
// if(m >= n)
//     Console.WriteLine("That won't work");
// else 
//     Console.WriteLine(Sum(n, m));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackermann (int m, int n)
// {
// if(m == 0)
//     return n + 1;
// else if(m > 0 && n == 0)
//     return Ackermann(m - 1, 1);
// return Ackermann(m - 1, Ackermann(m, n - 1));
// }

// int m = new Random().Next(1, 4);
// Console.WriteLine("M is " + m);
// int n = new Random().Next(1, 4);
// Console.WriteLine("N is " + n);
// Console.WriteLine(Ackermann(n, m));