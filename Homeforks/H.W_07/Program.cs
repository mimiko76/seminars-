//________Задача 47___________

// double[,] create2DRndmArray(int rows, int columns, int minValue, int maxValue)
// {
//    double[,] newArray = new double[rows, columns];
//    var rnd = new Random();
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          double num = rnd.NextDouble() * ((maxValue + 1) - minValue) + minValue;
//          newArray[i, j] = Math.Round(num, 1);
//       }
//    }
//    return newArray;
// }

// void show2DArray(double[,] myArray)
// {
//    for (int i = 0; i < myArray.GetLength(0); i++)
//    {
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          Console.Write(myArray[i, j] + (" "));
//       }
//       Console.WriteLine("");
//    }
// }

// Console.Write("Введите количество рядов в массиве:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число в массиве в массиве:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное строк в массиве:");
// int max = Convert.ToInt32(Console.ReadLine());


// double[,] newArray = create2DRndmArray(rows, columns, min, max);
// show2DArray(newArray);



//__________задача 50_________

// int[,] create2DRndmArray(int rows, int columns, int minValue, int maxValue)
// {
//    int[,] newArray = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//       }
//    }
//    return newArray;
// }

// void show2DArray(int[,] myArray)
// {
//    for (int i = 0; i < myArray.GetLength(0); i++)
//    {
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          Console.Write(myArray[i, j] + (" "));
//       }
//       Console.WriteLine("");
//    }
// }

// void numberSearch(int[,] myArray, int num)
// {
//    for (int i = 0; i < myArray.GetLength(0); i++)
//    {
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          if (myArray[i, j] == num)
//          {
//             Console.WriteLine($"Искомое число имеет индекс строка-{i + 1},столбец-{j + 1}");
//          }
//       }
//    }
// }

// Console.Write("Введите количество рядов в массиве:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число в массиве в массиве:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное строк в массиве:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите искомое число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = create2DRndmArray(rows, columns, min, max);
// show2DArray(myArray);
// if (num > max || num < min)
// {
//    Console.WriteLine($"Число {num} выходит за диапазон");
//    return;
// }
// else
// {
//    numberSearch(myArray, num);
// }




//________Задача 52__________


// int[,] create2DRndmArray(int rows, int columns, int minValue, int maxValue)
// {
//    int[,] newArray = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//       }
//    }
//    return newArray;
// }

// void show2DArray(int[,] myArray)
// {
//    for (int i = 0; i < myArray.GetLength(0); i++)
//    {
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          Console.Write(myArray[i, j] + (" "));
//       }
//       Console.WriteLine("");
//    }
// }


// void addOfNumbers(int[,] myArray)
// {
//    double result = 0;
//    for (int j = 0; j < myArray.GetLength(1); j++)
//    {
//       for (int i = 0; i < myArray.GetLength(0); i++)
//       {
//          result = myArray[i, j] + result;
//       }
//       result = result / myArray.GetLength(1);
//       Console.Write(Math.Round(result, 1) + " ");
//       result = 0;
//    }
// }


// Console.Write("Введите количество рядов в массиве:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число в массиве в массиве:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное строк в массиве:");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = create2DRndmArray(rows, columns, min, max);
// show2DArray(myArray);
// addOfNumbers(myArray);

