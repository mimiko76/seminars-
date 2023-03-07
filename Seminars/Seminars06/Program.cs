//Задача 1. Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

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

// int[] raversArray(int[] array)
// {
//    for (int i = 0; i < array.Length / 2; i++)
//    {
//       int temp = array[i];
//       array[i] = array[array.Length - i - 1];
//       array[array.Length - i - 1] = temp;
//    }
//    return array;
// }


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// newArray = raversArray(newArray);
// ShowArray(newArray);


//Задача 2.Напишите программу, которая принимает на вход три числа и 
//проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, каждая сторона должна быть меньше(строго) 
//суммы двух других сторон

// bool checkTriangle(int x, int y, int z)
// {
//    if ((x < y + z) && (z < y + x) && (y < z + x))
//    {
//       return true;
//    }
//    else return false;
// }




// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите минимальный ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{checkTriangle(a, b, c)}");


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 
//числа это 0 и 1, а последующие это сумма двух предыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

// void fibonachi(int arg)
// {
//    int num1 = 0;
//    int num2 = 1;
//    for (int i = 0; i < arg;)
//    {
//       Console.Write(num1 + " ");
//       num1 = num1 + num2;
//       i++;
//       if (i == arg) break;
//       Console.Write(num2 + " ");
//       num2 = num2 + num1;
//       i++;
//    }
// }
// fibonachi(10);


//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное 
//число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10



void dvoich(int arg)
{
   string result = string.Empty;
   while (arg > 0)
   {
      result = arg % 2 + result;
      arg = arg / 2;
   }
   Console.WriteLine(result);
   int num = Convert.ToInt32(result);
   Console.WriteLine(num);
}

dvoich(145);