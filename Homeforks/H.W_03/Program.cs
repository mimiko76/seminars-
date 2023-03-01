//________________Задача 19__________________
// int examination(string arg)
// {
//    string arg1 = Convert.ToString(arg);
//    arg1 = arg1.Remove(2, 3);
//    int num1 = Convert.ToInt32(arg1);
//    string arg2 = Convert.ToString(arg);
//    arg2 = arg2.Remove(0, 3);
//    int num2 = Convert.ToInt32(arg2);
//    if (num1 == num2)
//    {
//       int result = 1;
//       return result;
//    }
//    return num1;
// }
// Console.WriteLine("Введите пятизначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 9999 || num > 99999)
// {
//    Console.WriteLine("Вы ввели не пятизначное число, пожалуйста повторите попытку.");
//    return;
// }
// string number = Convert.ToString(num);
// int result = examination(number);

// if (result == 1) { Console.WriteLine($"Число {num} является полиндоромом"); }
// else { Console.WriteLine($"Число {num} не является полиндромом"); }
// Console.WriteLine(MyString.Remove(6, 1)); //первая цифра означает с какого индекса
// начать удалять, вторая цифра обозначает сколько символов удалить


//_________________Задача 21______________


// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) +
//    Math.Pow(zb - za, 2)), 2);
// }

// Console.WriteLine("Введите первую координату X:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите первую координату Y:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите первую координату Z:");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату X:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату Y:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату Z:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Расстояние между двумя точками -> {FindDistance(xa, ya, za, xb, yb, zb)}");


//________________Задача 23____________
// void calculation(int arg)
// {
//    int current = 1;
//    while (current <= arg)
//    {
//       Console.Write($"{current * current * current},");
//       current++;
//    }
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// calculation(num);