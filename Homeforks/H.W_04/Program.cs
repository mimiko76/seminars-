// void multiplication(int num1, int num2)
// {
//    if (num2 == 0 || num1 == 0)
//    {
//       Console.WriteLine("Не допустимо вводить ноль");
//    }
//    else
//    {
//       Console.WriteLine($"{num1}^{num2} = " + Math.Pow(num1, num2));
//    }
// }
// Console.WriteLine("Введите основание:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите показатель:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// multiplication(num1, num2);


// int d(int arg1)
// {
//    string arg2 = arg1.ToString();
//    int j = arg2.Length;
//    int num1 = arg1;
//    int result = 0;
//    for (int i = 0; i < j; i++)
//    {
//       int num2 = num1 % 10;
//       num1 = num1 / 10;
//       result = result + num2;
//    }
//    return result;
// }
// int result = d(452);
// Console.WriteLine(result);


// int[] CreateRandomArray(int minValue, int maxValue)
// {
//    int[] array = new int[8];
//    for (int i = 0; i < 8; i++)
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

// Console.WriteLine("Ведите минимальное число ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число");
// int max = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(min, max));
