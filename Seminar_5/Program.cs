// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9; 9]. Найдите сумму отрицательных и положительных элементов массива.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
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

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }
// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");


// 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
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

// int[] GetArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//          array[i] = array[i] * (-1);
//     }
// return array;
// }

// int[] array = CreateRandomArray(10);
// ShowArray(array);
// Console.WriteLine();
// ShowArray(GetArray(array));


// 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
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

// int[] MyArray = CreateRandomArray(10, 0, 20);
// ShowArray(MyArray);
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int ArrayCheck(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//         return 1;
//         }
//     }
//     return 0;
// }
// if (ArrayCheck(MyArray) == 1)
// {
//     Console.WriteLine("Является элементом массива");
// }
// else
// {
//     Console.WriteLine("Не является элементом массива");
// }

// Home work
// 1. Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//  int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
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
// int[] MyArray = CreateRandomArray(10, 100, 999);
// ShowArray(MyArray);
// int i = 0;
// int count = 0;
// while (i < MyArray.Length)
// {
//     if (MyArray[i] % 2 == 0)
//     {
//         count++;
//     }
//     i++;
// }
// Console.WriteLine(count);

// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
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
// int[] MyArray = CreateRandomArray(20, -100, 100);
// ShowArray(MyArray);
// int sum = 0;
// int ind = 1;
// while (ind < MyArray.Length)
// {
//     sum = sum + MyArray[ind];
//     ind = ind + 2;
// }
// Console.WriteLine(sum);

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// int n = 10;
// double[] array = new double[n];
// Random rand = new Random();
// for (int i = 0; i < n; i++)
// {
//     array[i] = rand.Next (-10, 10);
// }
// foreach (var item in array)
// {
//     Console.Write(item + " ");
// }
// double min = array[0];
// double max = array[0];
// int ind = 0;
// while (ind < n)
// {
//     if (array[ind] > max)
//     {
//     max = array[ind];
//     }
//     if (array[ind] < min)
//     {
//         min = array[ind];
//     }
//     ind++;
// }
// Console.WriteLine();
// Console.WriteLine($"Минимальное значение: {min}");
// Console.WriteLine($"Максимальное значение: {max}");
// Console.WriteLine($"Разность: {max - min}");