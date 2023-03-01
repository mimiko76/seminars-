//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из 
//промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }

// void ShowArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// void showCheck(int[] array)
// {
//    int minDigit = 0;
//    int maxDigit = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0) maxDigit += array[i];
//       else minDigit += array[i];
//    }
//    Console.WriteLine(minDigit);
//    Console.WriteLine(maxDigit);
// }

//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ведите минимальный ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите максимальный");
//int max = Convert.ToInt32(Console.ReadLine());


//Задача 2. Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }

// void ShowArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine(" ");
// }

// int[] invertArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] *= (-1);
//    }
//    return array;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// myArray = invertArray(myArray);
// ShowArray(myArray);

//Задача 3.Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }
// void ShowArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine(" ");
// }

// bool examinationDigit(int[] array, int num)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] == num)
//       {
//          Console.WriteLine($"Число {num} присутствует в индексе");
//          return true;
//       }
//    }
//    Console.WriteLine("Цифра не найдена");
//    return false;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите проверяемое число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = createRandomArray(size, min, max);
// ShowArray(myArray);
// examinationDigit(myArray, num);






//Задача 4.****Задайте одномерный массив из 123  случайных чисел. 
//Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }
// int findNum(int[] array)
// {
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 10 & array[i] < 99)
//       {
//          sum++;
//       }
//    }
//    return sum;
// }
// void ShowArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine(" ");
// }

// int[] myArray = CreateRandomArray(50, 0, 1000);
// ShowArray(myArray);
// Console.WriteLine(findNum(myArray));

