// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Enter 5-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
int i0 = num / 10000;
Console.Write(i0 + " ");
int i1 = (num / 1000) % 10;
Console.Write(i1 + " ");
int i3 = (num / 10) % 10;
Console.Write(i3 + " ");
int i4 = num % 10;
Console.Write(i4 + " ");

if (num < 10000 || num > 99999)
Console.WriteLine("It's not 5-digit! Do it again!");

else if (i0 == i4 && i1 == i3)
    Console.WriteLine("It is a palindrome");
else
    Console.WriteLine("No, it's not a palindrome");