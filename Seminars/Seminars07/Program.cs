// Задача 1.Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
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

// Console.WriteLine("Введите размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] array = create2DRandomArray(columns, rows, min, max);
// show2DArray(array);

//Задача 2. ****Задайте двумерный массив размера m на n, каждый 
//элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.


// int[,] create2DArray(int columns, int rows)
// {
//    int[,] newArray = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          newArray[i, j] = i + j;
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

// Console.WriteLine("Введите размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива");
// int columns = Convert.ToInt32(Console.ReadLine());


// int[,] array = create2DArray(columns, rows);
// show2DArray(array);


//Задача 3.Задайте двумерный массив. Найдите элементы, у 
//которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4


// int[,] create2DArray(int columns, int rows)
// {
//    int[,] newArray = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < columns; j++)
//       {
//          newArray[i, j] = i + j;
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

// int[,] DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i += 2)
//    {
//       for (int j = 0; j < array.GetLength(1); j += 2)
//       {
//          array[i, j] = array[i, j] * array[i, j];
//       }
//       Console.WriteLine();
//    }
//    return array;
// }

// Console.WriteLine("Введите размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = create2DArray(columns, rows);
// show2DArray(array);
// DArray(array);
// show2DArray(array);




//Задача 4. задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2           Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12



int[,] create2DRandomArray(int columns, int rows)
{
   int[,] newArray = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         newArray[i, j] = new Random().Next(0, 9);
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
         Console.Write(array[i, j] + (" "));
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}

void showDiagonalSum(int[,] array)
{
   int result = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (i == j) result = array[i, j] + result;
      }
   }
   Console.WriteLine(result);
}


Console.Write("Ввести количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] myArray = create2DRandomArray(columns, rows);
show2DArray(myArray);
showDiagonalSum(myArray);