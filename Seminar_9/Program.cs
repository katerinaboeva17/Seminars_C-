// Seminar_9

// 1. Задайте значение n. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до n.
// Console.Clear();
// Console.Write("Введите n: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1, n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine($"{m}->{SumNumbers(m)}");

// int SumNumbers(int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }

// 3. Напишите программу, которая на вход принимает два числа А и В и возводит число А в целую степень В с помощью рекурсии.
// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"{Pow(m, n)}");

// int Pow(int number, int rank)
// {
//     if (rank == 0) return 1;
//     if (rank == 1) return number;
//     return (number * Pow(number, rank - 1));
// }


// Home work

// 1. Задайте значения m и n. Напишите программу, которая выведет все натуральные числа в промежутке от m до n.
// Console.Clear();
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine());
// if (m > n)
// {
//     int buf = 0;
//     buf = m;
//     m = n;
//     n = buf;
// }
// Console.WriteLine(PrintNumbers(m, n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return (start.ToString());
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// 2. Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от m до n.
// Console.Clear();
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine());
// if (m > n)
// {
//     int buf = 0;
//     buf = m;
//     m = n;
//     n = buf;
// }
// Console.WriteLine(SumNumbers(m, n + 1));

// int SumNumbers(int start, int end)
// {
//     if (start == end) return 0;
//     return (start + SumNumbers(start + 1, end));
// }

// 3. Напишите программу вычисления функции Аккермана с поьощью рекурсии. Даны два неотрицательных числа m и n.
// Console.Clear();
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine());
// if (m < 0 || n < 0)
// Console.WriteLine("Undefined");

// Console.WriteLine(A(m, n));

// static int A(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return A(m - 1, 1);
//     if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
//     return A(m, n);
// }
// Console.ReadKey();