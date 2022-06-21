// Seminar 3
// 1.Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void getDot(int x, int y)
// {
//     if (x == 0 || y == 0)
//     {
//         Console.WriteLine("Нельзя определить четверть");
//     }
//     else
//     {
//          if (x > 0 && y > 0)
//         {
//             Console.WriteLine("1 четверть");
//         }
//          if (x < 0 && y > 0)
//         {
//             Console.WriteLine("2 четверть");
//         }
//          if (x < 0 && y < 0)
//         {
//             Console.WriteLine("3 четверть");
//         }
//         if (x > 0 && y < 0)
//         {
//             Console.WriteLine("4 четверть");
//         }
//     }
// }
// Console.WriteLine("Введите координаты x и y");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// getDot(x1, y1);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void getDot(int num)
// {
//     if (num == 1)
//         Console.WriteLine("x > 0, y > 0");
//     else if (num == 2)
//         Console.WriteLine("x < 0, y > 0");
//     else if (num == 3)
//         Console.WriteLine("x < 0, y < 0");
//     else if (num == 4)
//         Console.WriteLine("x > 0, y < 0");
//     else
//         Console.WriteLine("Введено некорректное число");
// }
// Console.WriteLine("Введите номер четверти");
// int a = Convert.ToInt32(Console.ReadLine());
// getDot(a);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Console.Clear();
// double distAB(int x1, int x2, int y1, int y2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// }
// Console.WriteLine("Введите координату x1");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2");
// int yb = Convert.ToInt32(Console.ReadLine());
// double res = Math.Round(distAB(x1:xa, y1:ya, x2:xb, y2:yb), 2);
// Console.WriteLine("Длина отрезка " + res);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25

// void listSqrt(int n)
// {
//     int count = 1;
//     Console.Write(n + " -> ");
//     if (n > 0)
//     while (count <= n)
//     {
//         Console.Write(Math.Pow(count, 2) + ", ");
//         count++;
//     }
//     else
//     Console.WriteLine("Введены некорректные данные");
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// listSqrt(num);


// Home work

// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да

// void Pal(int num)
// {
//     if (num < 10000 || num > 99999)
//     {
//         Console.WriteLine("Введены некорректные данные");
//     }
//     else
//     {
//     int n1 = num % 10;
//     int n2 = (num / 10) % 10;
//     int n3 = (num / 100) % 10;
//     int n4 = (num / 1000) % 10;
//     int n5 = num / 10000;
//     int res = n1 * 10000 + n2 * 1000 + n3 * 100 + n4 * 10 + n5;
//     if (res == num)
//     Console.WriteLine(num + " -> да");
//     else
//     Console.WriteLine(num + " -> нет");
//     }
// }
// Console.WriteLine("Введите пятизначное число");
// int n = Convert.ToInt32(Console.ReadLine());
// Pal(n);


// 2. Напишите программу, которая ппринимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double distAB(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }
// Console.WriteLine("Введите координату x1");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату y1");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату z1");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату x2");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату y2");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату z2");
// double zb = Convert.ToDouble(Console.ReadLine());
// double res = Math.Round(distAB(x1:xa, y1:ya, z1:za, x2:xb, y2:yb, z2:zb), 2);
// Console.WriteLine("Расстояние между точками " + res);

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

// void cube(int n)
// {
//     int count = 1;
//     if (n < 1)
//     Console.WriteLine("Введены некорректные данные");
//     else
//     while (count <= n)
//     {
//         Console.Write(Math.Pow(count, 3) + ", ");
//         count++;
//     } 
// }
// Console.WriteLine("Введите натуральное число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(num + " -> ");
// cube(num);
