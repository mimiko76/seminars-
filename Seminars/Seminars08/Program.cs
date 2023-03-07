//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет 
//местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

//РЕАЛИЗУЕМ МЕТОД ПОИНТЕРЕСНЕЕ ОН БУДЕТ МЕНЯТЬ ЛЮБУЮ С ЛЮБОЙ СТРОКИ

// int[,] create2DRandomArray(int columns, int rows, int minValue, int maxValue)
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

// void show2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine("");
//    }
//    Console.WriteLine("");
// }

// int[,] changeRows(int[,] myArray, int row1, int row2)
// {
//    row1--;
//    row2--;
//    if (row1 > myArray.GetLength(0) || row2 > myArray.GetLength(0) || row1 < 0 || row2 < 0)
//    {
//       Console.WriteLine("invalid rows");
//       return myArray;
//    }
//    else
//    {
//       for (int j = 0; j < myArray.GetLength(1); j++)
//       {
//          int temp = myArray[row1, j];
//          myArray[row1, j] = myArray[row2, j];
//          myArray[row2, j] = temp;
//       }
//    }
//    return myArray;
// }

// Console.WriteLine("Введите размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of first row to change");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of second row to change");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = create2DRandomArray(columns, rows, min, max);
// show2DArray(myArray);
// myArray = changeRows(myArray, row1, row2);
// show2DArray(myArray);



//Задание 2. Задайте двумерный массив. Напишите программу,которая заменяет строки 
//на столбцы. В случае, если это невозможно, программа должна вывести сообщение 
//для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7


// int[,] create2DRandomArray(int columns, int rows, int minValue, int maxValue)
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

// void show2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine("");
//    }
//    Console.WriteLine("");
// }

// int[,] rowsToColumns(int[,] array)
// {
//    if (array.GetLength(0) != array.GetLength(1))
//    {
//       Console.WriteLine("Row and column count mismatch");
//       return array;
//    }
//    else
//    {
//       for (int i = 0; i < array.GetLength(0) - 1; i++)
//       {
//          for (int j = i++; j < array.GetLength(1); j++)
//          {
//             int temp = array[i, j];
//             array[i, j] = array[i, j];
//             array[j, i] = temp;
//          }
//       }
//       return array;
//    }
// }


// Console.WriteLine("Введите размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = create2DRandomArray(columns, rows, min, max);
// show2DArray(myArray);
// myArray = rowsToColumns(myArray);
// show2DArray(myArray);


//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
// то есть удаляем и строку и столбец в которой находится этот элемент


int[,] create2DRandomArray(int columns, int rows, int minValue, int maxValue)
{
   int[,] newArray = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         newArray[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return newArray;
}

void show2DArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
   Console.WriteLine("");
}

int[,] deliteMinEllemente(int[,] array)
{
   int min = array[0, 0];
   int rowMin = 0;
   int columMin = 0;

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j] < min)
         {
            min = array[i, j];
            rowMin = i;
            columMin = j;
         }
      }
   }
   for (int i = 0; i < array.GetLength(0); i++)
   {
      array[i, columMin] = 0;
   }
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[rowMin, j] = 0;
   }
   return array;
}

Console.WriteLine("Введите размер массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите минимальный ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = create2DRandomArray(columns, rows, min, max);
show2DArray(myArray);
myArray = deliteMinEllemente(myArray);
show2DArray(myArray);
