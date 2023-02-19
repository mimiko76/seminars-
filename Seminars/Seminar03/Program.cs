// Задание1.  Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер
// четверти плоскости, в которой находится эта точка.

// int FindQuart(double x, double y)
// {
//    if (x > 0 && y > 0) return 1;
//    if (x < 0 && y > 0) return 2;
//    if (x < 0 && y < 0) return 3;
//    if (x > 0 && y < 0) return 4;

//    return 0;
// }
// Console.WriteLine("Введите X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindQuart(x, y));

//Задача 3. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.
// Нужна теорема пифагора
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }

// Console.WriteLine("Input coordinate X for first point:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for first point:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X for second point:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for second point:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa, ya, xb, yb)}");


//Задача 2.Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// string FindDiapason(int num)
// {
// if (num == 1) { return "x > 0, y > 0"; }
// if (num == 2) { return "x < 0, y > 0"; }
// if (num == 3) { return "x < 0, y < 0"; }
// if (num == 4) { return "x > 0, y < 0"; }
// return "Wrong Quadrat";
// }

// Console.Write("Input Quadrant: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindDiapason(q));

//Задача 4. Напишите программу которая принимает на вход число (N)
//и выдает на консоль квадраты чисел от 1 до N

// void SquareLine(int num)
// {
// int counter = 1;

// while (counter <= num)
// {
//     Console.WriteLine($"{counter} -> {counter * counter} ");
//     counter++;
// }
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SquareLine(n);