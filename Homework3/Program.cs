// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Enter 5-digit number ");
    int num = Convert.ToInt32(Console.ReadLine());

while (1000 > num || num > 99999)
        Console.WriteLine("Wroooong, do it again!");

if (Convert.ToString(num)[0] == Convert.ToString(num)[4] && Convert.ToString(num)[1] == Convert.ToString(num)[3]);
    Console.WriteLine("It is a palindrome");

else
    Console.WriteLine("No, it's not a palindrome");
