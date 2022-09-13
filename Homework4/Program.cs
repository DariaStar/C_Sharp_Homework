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

// Console.WriteLine("Enter number with more than 2-digits: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// if (num < 10)
// Console.WriteLine("Number doesn't have 2 digits");

// while (num > 0)
// {
//     sum += num % 10;
//     num /= 10;
// }
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 100);
    
//  Console.WriteLine("[" + string.Join(", ", array) + "]");

//Задача 496. Сбор черники:

// Всего на грядке растет N кустов. 
//Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.
//Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним
//Напишите программу для нахождения максимального числа ягод
//которое может собрать за один заход собирающий модуль
//находясь перед некоторым кустом заданной во входном файле грядки.
//целое число N (3 ≤ N ≤ 1000) – количество кустов черники.
//Вторая строка содержит N целых положительных чисел a1, a2, ..., 
//aN – число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.

// Console.WriteLine("Сколько кустов: ");
// int bush = Convert.ToInt32(Console.ReadLine());


// if(bush < 3 || bush > 999)
// Console.WriteLine("Неверное число кустов");

// else
// {
// int[] berries = new int[bush];

// for (int i = 0; i < berries.Length; i++)
//      berries[i] = new Random().Next(0, 100);
    
//   Console.WriteLine("Ягод на кустах: [" + string.Join(", ", berries) + "]");


// int[] max_berries = new int[bush];
// for (int i = 1; i < berries.Length - 1; i++)
// {
//     max_berries[i - 1] = berries[i - 1] + berries[i] + berries[i + 1];
// }
// max_berries[max_berries.Length - 2] = berries[berries.Length - 1] + berries[0] + berries[1];
// max_berries[max_berries.Length - 1] = berries[0] + berries[berries.Length - 1] + berries[berries.Length - 2];
// Console.WriteLine("Максимальное с трех кустов: [" + string.Join(", ", max_berries) + "]");

// int max = max_berries[0];
// for (int i = 1; i < max_berries.Length; i++)
// {
//     if (max < max_berries[i])
//         max = max_berries[i];
// }
// Console.WriteLine("Максимаьное количество ягод: " + max);
// }





