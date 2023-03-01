// int Prompt(string message)
// {
//    System.Console.Write(message);
//    string value = Console.ReadLine();
//    int result = Convert.ToInt32(value);
//    return result;
// }

// int number = Prompt("Введите трехзначное значение: ");
// if (number < 100 || number > 999)
// {
//    Console.WriteLine("Вы не ввели трехзначное число, Пожалуйста повторите ввод");
//    return;
// }
// Console.WriteLine($"Введено число {number}");
// int SecondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра {SecondRank}");

// int FindThreeNum(int arg)
// {
//    if (arg < 100)
//    {
//       Console.WriteLine($"Третьей цифры нет");
//    }
//    if (arg > 99 && arg < 1000)
//    {
//       int res = arg % 10;
//       return res;
//    }
//    if (arg > 999 && arg < 10000)
//    {
//       int des = arg / 10;
//       int res = des % 10;
//       return res;
//    }
//    if (arg > 9999 && arg < 100000)
//    {
//       int sot = arg / 100;
//       int res = sot % 10;
//       return res;
//    }
//    if (arg > 99999)
//    {
//       int res = -1;
//       return res;
//    }

//    return arg;
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = FindThreeNum(num);
// if (result < 100)
// {
//    Console.Write("");
// }
// if (result == -1)
// {
//    Console.WriteLine($"Число {num} слишком большое");
// }
// if (result < 9)
// {
//    Console.WriteLine($"Ваши третья цифра {result}");
// }


// int FindWeekend(int arg)
// {
//    if (arg == 6)
//    {
//       Console.WriteLine($"Это суббота");
//    }
//    if (arg == 7)
//    {
//       Console.WriteLine($"Это воскресенье");
//    }
//    else
//    {
//       Console.WriteLine("Это не выходной");
//    }
//    return arg;
// }

// Console.WriteLine("Введите число дня понедельник-1, вторник-2 ...:");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = FindWeekend(num);
