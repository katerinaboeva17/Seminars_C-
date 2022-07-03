//Seminar_7

// 1. Задайте двумерный массив размера m на n, заполненный случайными целыми числами.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return myArray;
// }

// void ShowArray(int[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//      Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);

// 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] CreateArray(int m, int n)
// {
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = i + j;
//         }
//     }
//     return myArray;
// }

// void ShowArray(int[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] myarray = CreateArray(rows, columns);
// ShowArray(myarray);


// 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return myArray;
// }
// void ShowArray(int[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//      Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void EvenArray(int[,] myArray)
// {

//     for (int i = 2; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 2; j < myArray.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             myArray[i, j] = myArray[i, j] * myArray[i, j];
//         }
//     } 
// } 
//  Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// EvenArray(myArray);
// ShowArray(myArray);

// 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return myArray;
// }

// void ShowArray(int[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
    
// }

// int SumNumbers(int[,] myArray)
// {
//     int sum = 0;
//      for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             if(i == j)
//             sum += myArray[i, j];
//         }
//     }
//     return sum;
// }
// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myarray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myarray);
// Console.WriteLine(SumNumbers(myarray));

// Home work
// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandomArray(int m, int n)
// {
//     double[,] myArray = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = Math.Round((new Random().NextDouble() * 10), 2);
//         }
//     }
//     return myArray;
// }

// void ShowArray(double[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//      Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = CreateRandomArray(rows, columns);
// ShowArray(myArray);

// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandomArray()
// {
//     int m = new Random().Next(1, 10);
//     int n = new Random().Next(1, 10);
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return myArray;
// }

// void ShowArray(int[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//      Console.WriteLine();
//     }
// }
// void ShowElem(int[,] myArray, int m, int n)
// {
//     if (m >= myArray.GetLength(0) || n >= myArray.GetLength(1) || m < 0 || n < 0)
//     {
//         Console.WriteLine("Element not found");
//     }
//     else
//     Console.WriteLine(myArray[m, n]);
// }
// int[,] myarray = CreateRandomArray();
// ShowArray(myarray);
// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// ShowElem(myarray, rows, columns);

// 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return myArray;
// }

// void ShowArray(int[,] myArray)
// {

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             Console.Write(myArray[i, j] + " ");
//         }
//      Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ArithMean(int[,] myArray)
// {
//     int count = myArray.GetLength(0);
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < myArray.GetLength(0); i++)
//             {
//                 sum = sum + myArray[i, j];
//             }
//         double arMean = Math.Round((sum / count), 1);
//         Console.Write(arMean + " ");
//     }
// }

// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// ArithMean(myArray);



