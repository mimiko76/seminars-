// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(minValue, maxValue + 1);
//    }
//    return array;
// }

// void showArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }
// void checkPositiveDigit(int[] array)
// {
//    int result = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0) result++;
//    }
//    Console.WriteLine($"Введенных положительных чисел: {result}");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите минимальное трехзначное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное трехзначное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = createRandomArray(size, min, max);
// showArray(myArray);
// checkPositiveDigit(myArray);