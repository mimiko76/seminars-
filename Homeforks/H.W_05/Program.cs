//_______________Задача 34______________

// bool examination(int num1, int num2)
// {
//    if (num1 < 100 || num2 > 999 || num2 < 100)
//    {
//       Console.WriteLine("Указанный диапазон не соответствует");
//       return false;
//    }
//    if (num1 == num2)
//    {
//       Console.WriteLine("Числа равны, поиск невозможен");
//       return false;
//    }
//    if (num2 < num1)
//    {
//       Console.WriteLine($"Максимальное число({num2}) не может быть меньше минимального({num1})");
//       return false;
//    }
//    return true;
// }

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

// void showPositiveNum(int[] array)
// {
//    int result = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] % 2 == 0) result++;
//    }
//    Console.WriteLine(result);
// }



// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите минимальное трехзначное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное трехзначное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());


// if (examination(min, max))
// {
//    int[] myArray = createRandomArray(size, min, max);
//    showArray(myArray);
//    showPositiveNum(myArray);
// }



//_______________Задача 36_______________


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

// void findOddPosition(int[] array)
// {
//    int sum = 0;
//    for (int i = 0; i < array.Length; i = i + 2)
//    {
//       sum += array[i];
//    }
//    Console.WriteLine(sum);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = createRandomArray(size, min, max);
// showArray(myArray);
// findOddPosition(myArray);


//______________Задача 36_______________


// double[] createRandomDouble(int size, double minValue, double maxValue)
// {
//    double[] array = new double[size];
//    var rnd = new Random();
//    for (int i = 0; i < array.Length; i++)
//    {
//       double num = rnd.NextDouble() * (maxValue - minValue) + minValue;
//       array[i] = Math.Round(num, 1);// вторая цифра означает сколько дробных частей будет выведено 
//    }
//    return array;
// }


// void showArray(double[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// void findDifferenceMinMax(double[] array)
// {
//    double max = array[0];
//    double min = array[0];
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] < min) min = array[i];
//       if (array[i] > max) max = array[i];
//    }
//    double result = max - min;
//    result = Math.Round(result, 1);
//    Console.WriteLine(result);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите минимальное значение: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// double max = Convert.ToDouble(Console.ReadLine());

// double[] myArray = createRandomDouble(size, min, max);
// showArray(myArray);
// findDifferenceMinMax(myArray);
