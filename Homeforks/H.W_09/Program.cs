
//_________________Задача 54_____________

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
//    Console.WriteLine("");
// }

// void OrderArrayLines(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(1) - 1; k++)
//          {
//             if (array[i, k] < array[i, k + 1])
//             {
//                int temp = array[i, k + 1];
//                array[i, k + 1] = array[i, k];
//                array[i, k] = temp;
//             }
//          }
//       }
//    }
// }

// int[,] newArray = create2DRndmArray(4, 4, 0, 10);
// show2DArray(newArray);
// OrderArrayLines(newArray);
// Console.WriteLine($"\nОтсортированный массив: ");
// show2DArray(newArray);


//________________Задача 56__________


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
//    Console.WriteLine("");
// }

// void FindSmallestSumStringInArray(int[,] myArray)
// {
//    int num = 0;
//    int result = 0;
//    int num2 = 0;
//    for (int i = 0; i < myArray.GetLength(1); i++)
//    {
//       num = myArray[0, i] + num;
//    }
//    for (int i = 0; i < myArray.GetLength(0); i++)
//    {
//       num2 = 0;
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          num2 = myArray[i, j] + num2;
//       }
//       if (num2 <= num) result = i;
//    }
//    Console.WriteLine(result);
// }

// int[,] newArray = create2DRndmArray(6, 4, 0, 10);
// show2DArray(newArray);
// FindSmallestSumStringInArray(newArray);




//___________Задача 58________


// int[,] CreateFirstMatrix(int rows, int columns, int maxValue)
// {
//    int[,] newArray = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          newArray[i, j] = new Random().Next(0, maxValue + 1);
//       }
//    }
//    return newArray;
// }


// int[,] CreateSecondMatrix(int rows, int columns, int maxValue)
// {
//    int[,] newArray = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          newArray[i, j] = new Random().Next(0, maxValue + 1);
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
//    Console.WriteLine("");
// }


// int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
// {
//    int[,] ResultMatrix = new int[matrix1.GetLength(1), matrix2.GetLength(0)];
//    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < ResultMatrix.GetLength(1); j++)
//       {
//          int sum = 0;
//          for (int k = 0; k < matrix1.GetLength(1); k++)
//          {
//             sum += matrix1[i, k] * matrix2[k, j];
//          }
//          ResultMatrix[i, j] = sum;
//       }
//    }
//    return ResultMatrix;
// }

// Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int InputNumbers(string input)
// {
//    Console.Write(input);
//    int output = Convert.ToInt32(Console.ReadLine());
//    return output;
// }
// int[,] FirstMatrix = CreateFirstMatrix(m, n, range);
// int[,] SecondMatrix = CreateSecondMatrix(n, p, range);
// show2DArray(FirstMatrix);
// show2DArray(SecondMatrix);
// int[,] newMatrix = MatrixMultiplication(FirstMatrix, SecondMatrix);
// show2DArray(newMatrix);



//______Задача 60______

// int[,,] create3DRndmArray(int rows, int columns, int depth)
// {
//    int[,,] newArray = new int[rows, columns, depth];
//    int[] temp = new int[newArray.GetLength(0) * newArray.GetLength(1) * newArray.GetLength(2)];
//    for (int i = 0; i < temp.GetLength(0); i++)
//    {
//       temp[i] = new Random().Next(10, 100);
//       for (int j = 0; j < i; j++)
//       {
//          while (temp[i] == temp[j])
//          {
//             temp[i] = new Random().Next(10, 100);
//             j = 0;
//          }
//       }
//    }
//    int count = 0;
//    for (int i = 0; i < newArray.GetLength(0); i++)
//    {
//       for (int j = 0; j < newArray.GetLength(1); j++)
//       {
//          for (int k = 0; k < newArray.GetLength(2); k++)
//          {
//             newArray[i, j, k] = temp[count];
//             count++;
//          }
//       }
//    }
//    return newArray;
// }


// void show3DArray(int[,,] myArray)
// {
//    for (int i = 0; i < myArray.GetLength(0); i++)
//    {
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          for (int k = 0; k < myArray.GetLength(2); k++)
//          {
//             Console.Write($"{i},{j},{k}" + "-" + myArray[i, j, k] + "  ");
//          }
//          Console.WriteLine(" ");
//       }
//    }
//    Console.WriteLine("");
// }


// int[,,] newArray = create3DRndmArray(2, 2, 2);
// show3DArray(newArray);




//________Задача 62________
int[,] HelicalArrayFilling(int rows, int columns)
{
   int n = 4;
   int[,] myArray = new int[n, n];

   int temp = 1;
   int vertical = 0;
   int horizontal = 0;

   while (temp <= myArray.GetLength(0) * myArray.GetLength(1))
   {
      myArray[vertical, horizontal] = temp;
      temp++;
      if (vertical <= horizontal + 1 && vertical + horizontal < myArray.GetLength(1) - 1)
         horizontal++;
      else if (vertical < horizontal && vertical + horizontal >= myArray.GetLength(0) - 1)
         vertical++;
      else if (vertical >= horizontal && vertical + horizontal > myArray.GetLength(1) - 1)
         horizontal--;
      else
         vertical--;
   }
   return myArray;
}

void show2DArray(int[,] myArray)
{
   for (int i = 0; i < myArray.GetLength(0); i++)
   {
      for (int j = 0; j < myArray.GetLength(1); j++)
      {
         Console.Write(myArray[i, j] + (" "));
      }
      Console.WriteLine("");
   }
}






int[,] myArray = HelicalArrayFilling(4, 4);

show2DArray(myArray);
