//Задача 1
//Console.WriteLine("GB Lesson");
//int num = 5;
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num + " " + num2);
//Задача 2 
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"Quad of {num} is {quad}");


//Задача3 Напишите программу которая принимает на вход два числа и проверяет, является ли ервое число квадратом второго
// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if (quad == num1)
// {
//    Console.WriteLine("First number is quad of second number");
// }
// else
// {
//    Console.WriteLine("first number is not quad second number");
// }

//Задача 4 Напишите программу, которая на вход принимает число (N), а на выходе все целые числа в промежуточном от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while (current <= num)
// {
//    Console.Write(current + " ");
//    current++;
// }


//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
// Console.WriteLine("Input number three digit ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 10;

// Console.WriteLine($"last digit of {num} is {result}");

