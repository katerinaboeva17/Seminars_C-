//Seminar_8

// 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
// void SwapArray(int[,] myArray)
// {
//     int buf = 0;
//     int lastRow = myArray.GetLength(0) - 1;
//     for (int columns = 0; columns < myArray.GetLength(1); columns++)
//     {  
//         buf = myArray[0, columns];
//         myArray[0, columns] = myArray[lastRow, columns];
//         myArray[lastRow, columns] = buf;
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
// Console.WriteLine();
// SwapArray(myArray);
// ShowArray(myArray);



// 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение  для пользователя.

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
// int[,] SwapArray(int[,] myArray)
// {
//     int [,] ArrayNew = new int[myArray.GetLength(0), myArray.GetLength(1)];
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {  
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             ArrayNew[j, i] = myArray[i, j];
//         }
//     }
//     Console.WriteLine();
//     return ArrayNew;
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
// if (rows == columns)
// ShowArray(SwapArray(myArray));
// else
// {
//     Console.WriteLine("Unable to execute");
// }


// 3. Составьте частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

// void ShowArrayTwo(int[,] myArray)
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

// int [] GetOneArray(int[,] arrayTwo)
// {
//     int [] arrayOne = new int[arrayTwo.GetLength(0) * arrayTwo.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < arrayTwo.GetLength(0); i++)
//     {  
//         for (int j = 0; j < arrayTwo.GetLength(1); j++)
//         {
//             arrayOne[index] = arrayTwo[i, j];
//             index++;
//         }
//     }
//     return arrayOne;
// }
// void SortArray(int[] array)
// {
//     int buf = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] > array[j])
//             {
//                 buf = array[i];
//                 array[i] = array[j];
//                 array[j] = buf;
//             }
//         }
//     }
// }
// void PrintCounElement(int[] array)
// {
//     int count = 0;
//     int temp = array[0];
//     for (int i = 0; i < array.Length; i++)
//     { 
//         if (array[i]!= temp)
//         {
//             Console.WriteLine($"{temp} встречается {count} раз");
//             temp = array[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{temp} встречается {count} раз");
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
// ShowArrayTwo(myArray);
// int[] arrayOne = GetOneArray(myArray);
// Console.WriteLine(String.Join(" ", arrayOne));
// SortArray(arrayOne);
// Console.WriteLine(String.Join(" ", arrayOne));
// PrintCounElement(arrayOne);


// Home work

// 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// void SortArray(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
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
// Console.WriteLine();
// SortArray(myArray);
// ShowArray(myArray);

// 2. Задайте прямоугольный двумерный массив. Напишите программу, котрая будет находить строку с наименьшей суммой элементов.

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
// void StringSum(int[,] array)
// {
//     int [] oneArray = new int[array.GetLength(0)];
//     int ind = 0;
    
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                     sum = sum + array[i, j];
                    
//             }
//         oneArray[ind] = sum;
//         ind++;
//         }
//     int min = oneArray[0];
//     for (int index = 0; index < oneArray.Length; index++)
//     {
//         if (oneArray[index] < min)
//         {
//             min = oneArray[index];
//         }
//     }
//     Console.WriteLine(String.Join(" ", oneArray));
//     Console.WriteLine();
//     int indexMin = Array.IndexOf(oneArray, min);
//     Console.WriteLine(indexMin);
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
// Console.WriteLine();
// StringSum(myArray);


// 3. Задате две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// int[,] MatrixProduct(int[,] array1, int[,] array2)
//     {
//         int[,] array3 = new int [array1.GetLength(0), array2.GetLength(1)];
//         for (int i = 0; i < array1.GetLength(0); i++)
//         {
//             for (int j = 0; j < array2.GetLength(1); j++)
//             {
//                 for (int k = 0; k < array1.GetLength(1); k++)
//                 {
//                     array3[i, j] += array1[i, k] * array2[k, j];
//                 }
//             }
             
//         }
//        return array3;
//     }
    

// Console.WriteLine("Enter number of rows arrayOne:");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns arrayOne:");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number:");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number:");
// int max1 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray1 = CreateRandomArray(rows1, columns1, min1, max1);
// Console.WriteLine("Enter number of rows arrayTwo:");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns arrayTwo:");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number:");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number:");
// int max2 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray2 = CreateRandomArray(rows2, columns2, min2, max2);
// ShowArray(myArray1);
// Console.WriteLine();
// ShowArray(myArray2);
// Console.WriteLine();
// ShowArray(MatrixProduct(myArray1, myArray2));

// 5. Заполнить спиралью массив 4 на 4.


// int[,] CreatArray(int m, int n)
// {
// int[,] array = new int[m, n];
// for (int i = 0, j = 0; j < array.GetLength(1); j++)
//     {
//         Console.WriteLine("Введите " + i + j + " элемент");
//         array[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// for (int j = n - 1, i = 1; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine("Введите " + i + j + " элемент");
//         array[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// for (int i = m - 1, j = n - 2; j >= 0; j--)
//     {
//         Console.WriteLine("Введите " + i + j + " элемент");
//         array[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// for (int j = 0, i = m - 2; i >= 1; i--)
//     {
//         Console.WriteLine("Введите " + i + j + " элемент");
//         array[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// for (int i = 1, j = 1; j < array.GetLength(1) - 1; j++)
// {
//     Console.WriteLine("Введите " + i + j + " элемент");
//     array[i, j] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = m - 2, j = n - 2; j >= 1; j--)
// {
//     Console.WriteLine("Введите " + i + j + " элемент");
//     array[i, j] = Convert.ToInt32(Console.ReadLine());
// }
//     return array;
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

// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int col = Convert.ToInt32(Console.ReadLine());
// int [,] myarray = CreatArray(rows, col);
// ShowArray(myarray);