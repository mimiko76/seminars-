//Задача 1. Напишите программу, которая принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36
// int FindSum(int a)
// {
//    int sum = 0;
//    for (int current = 1; current <= a; current++)
//    {
//       sum = sum + current;// альтернативная запись sum += current;
//    }
//    return sum;
// }
// Console.WriteLine("Введите A");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));


//Задача 4. Напишите программу, которая выводит массив из любого количества элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(minValue, maxValue + 1);
   }
   return array;
}

void ShowArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i] + " ");
   }
   Console.WriteLine();
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите минимальный ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный");
int max = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreateRandomArray(size, minValue, maxValue); //нужно выбрать один вариант

ShowArray(CreateRandomArray(size, min, max));// второй вариант

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//_____вариант строкой

// string str = "3444";
// int length = str.Length;
// Console.WriteLine(length);

//_______вариант с числами

// int NumberOfDigit(int x)
// {
//    int count = 0;
//    while (x > 0)
//    {
//       x = x / 10;
//       count = count + 1;
//    }
//    return count;
// }


// Console.WriteLine("Input X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{NumberOfDigit(X)}");