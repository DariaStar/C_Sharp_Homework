// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Enter 5-digit number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i0 = num / 10000;
// int i1 = (num / 1000) % 10;
// int i3 = (num / 10) % 10;
// int i4 = num % 10;

// if (num < 10000 || num > 99999)
// Console.WriteLine("It's not 5-digit! Do it again!");

// else if (i0 == i4 && i1 == i3)
//     Console.WriteLine("It is a palindrome");
// else
//     Console.WriteLine("No, it's not a palindrome");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Enter x1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z1 ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z2 ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

// Console.WriteLine("Distance is " + $"{dist:0.00}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Enter number ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// for(i =1; i < N + 1; i++)
// {
// double n = Math.Pow(i, 3);
//     Console.WriteLine(i + "^3 = " + n);
// }

// Задача 264. Оттепель.
// Оттепелью они называют период, в который среднесуточная температура ежедневно превышала 0 градусов Цельсия. 
// Входные данные
// Сначала записано число N – общее количество рассматриваемых дней (1 ≤ N ≤ 100). 
// В следующей строке через пробел располагается N целых чисел, разделенных пробелами.
// Каждое число – среднесуточная температура в соответствующий день. Температуры – целые числа и лежат в диапазоне от –50 до 50.

// Выходные данные
// В выходной файл OUTPUT.TXT требуется вывести одно число – длину самой продолжительной оттепели, 
// то есть наибольшее количество последовательных дней, на протяжении которых среднесуточная температура превышала 0 градусов. 
// Если температура в каждый из дней была неположительной, выведите 0.
 
// Console.WriteLine("Enter how many days ");
// int days = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int count = 0;
// int count_max = 0;

// for (i = 1; i < days + 1; i++)
// {
// Random rnd = new Random(); 
// int temp = rnd.Next(-50, 50); 
// Console.Write(temp + " "); 

// if (temp > 0) 
// {
//     count++; 
//     if(count_max < count)
//         count_max = count;
// }
// else
//     count = 0;
// }

// Console.WriteLine("Total: " + count_max);
