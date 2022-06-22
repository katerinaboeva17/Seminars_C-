// Seminar 4

// 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int SumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма элементов равна " + SumToNum(number));

// 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int Count(int num)
// {
//     int count = 0;
//     if (num < 0)
//     num = Math.Abs(num);
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество цифр равно " + Count(n));

// 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// int multiplay(int num)
// {
//     int count = 1;
//     int i = 1;
//     if (num < 1)
//     Console.WriteLine("Введены некорректные данные");
//     for (i = 1; i <= num; i++)
//     {
//         count = count * i;
//     }
//     return count;
// }
// Console.WriteLine("Введите натуральное число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Факториал равен " + multiplay(n));

// 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

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

// int[] myRandomArray = CreateRandomArray(8);
// ShowArray(myRandomArray);


// Home work
// 1. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// int Pow(int x, int n)
// {
//     int res = 1;
//     for (int count = 1; count <= n; count++)
//     {
//         res = res * x;
//     } 
//     return res;
// }
// Console.WriteLine("Введите целое число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int B = Convert.ToInt32(Console.ReadLine());
// if (B < 1)
// Console.WriteLine("Введены некорректные данные");
// Console.WriteLine(Pow(A, B));

// 2. Напишите программу, котрая принимает на вход число и выдаёт сумму цифр в числе.
// int Sum(int num)
// {
//     if (num < 0)
//     num = Math.Abs(num);
//     int sum = 0;
//     while (num % 10 > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return(sum);
// }
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(a));

// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] CreatArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//     Console.WriteLine("Введите " + i + " элемент");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] MyArray = CreatArray(8);
// ShowArray(MyArray);