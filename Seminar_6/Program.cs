// 1. Написать программу, которая перевернёт массив.
// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void SwapArray(int[] array)
// {
//     int buf = 0;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         buf = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = buf;
//     }
// }

// int[] myRandomArray = RandomArray(10);
// ShowArray(myRandomArray);
// SwapArray(myRandomArray);
// ShowArray(myRandomArray);

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void SwapArray(int[] array)
// {
//     int[] arr = new int[array.Length];
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         arr[i] = array[j];
//     }
//     ShowArray(arr);
// }

// int[] myarray = RandomArray(10);
// ShowArray(myarray);
// SwapArray(myarray);


// 2. Написать программу, которая принимает три числа и проверяет, существует ли треугольник с такими сторонами.
// bool Trigon(double a, double b, double c)
// {
//     if (a < b + c && b < a + c && c < b + a)
//     {
//         return true;
//     }
//     else
//     return false;
// }
// double x = new Random().NextDouble();
// Console.WriteLine("{0:f5}", x);
// double y = new Random().NextDouble();
// Console.WriteLine("{0:f5}", y);
// double z = new Random().NextDouble();
// Console.WriteLine("{0:f5}", z);

// if (Trigon(x, y, z))
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
// Console.WriteLine("Треугольник не существует");
// }


// Home work
// 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Введите " + i + " элемент");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] MyArray = CreateArray(7);
// ShowArray(MyArray);
// int count = 0;
// for (int i = 0; i < MyArray.Length; i++)
// {
//     if (MyArray[i] > 0)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(count);

// 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// int ConvertDecBin(int number)
// {
//     int binNum = 0;
//     int count = 0;
//     while (number >= 1)
//     {
//         if (count == 0) count = 1;
//         else count = count * 10;
//         binNum = binNum + (number % 2) * count;
//         number = number / 2;
//     }
//     return binNum;
// }
// Console.WriteLine("Please enter positive number:");
// int decNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(decNum + " -> " + ConvertDecBin(decNum));

// string number = "3";
// int fromBase = 10;
// int toBase = 2;
// string binNum = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
// Console.WriteLine(binNum);

// 3. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void CrossingPoint (double k1, double b1, double k2, double b2)
// {
//     if (k1 == k2 && b1 == b2)
//     Console.WriteLine("Straight lines match");

//     else if (k1 == k2)
//     Console.WriteLine("Straight lines are parallel");

//     else
//     {
//         double x = Math.Round ((b2 - b1) / (k1 - k2), 1);
//         double y = Math.Round((k1 * x + b1), 1);
//         Console.WriteLine($"({x}; {y})");
//     }
// }
// Console.WriteLine("Enter k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// CrossingPoint(k1, b1, k2, b2);

// 4. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Fibonacci(int n)
// {   
//     int[] array = new int[n];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i -1] + array[i - 2];
//     }
//     ShowArray(array);
// }
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// Fibonacci(n);
