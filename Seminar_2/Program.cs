// Seminar_2
// 1. Напишите программу, которая выводит случайное число из отрезка [10; 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2
// 85-> 8

// void ShowNumber()
// {
//     int num = new Random().Next(10, 100);
//     int firstNum = num / 10;
//     int secondNum = num % 10;
//     Console.Write(num + " -> ");
//     if (firstNum > secondNum)
//     {
//         Console.Write(firstNum);
//     }
//     else
//     {
//         Console.Write(secondNum);
//     }
// }
// ShowNumber();


// 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// void ShowNumber()
// {
//     int num = new Random().Next(100, 1000);
//     int num1 = num / 100;
//     int num3 = num % 10;
//     int result = num1 * 10 + num3;
//     Console.WriteLine(num + " -> " + result);
// }
// ShowNumber();


// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно.

// void MultiNum(int a, int b)
// {
//   int rem = b % a;
//   if (rem == 0)
//   {
//     Console.Write(b + ", ");
//     Console.WriteLine(a + " -> кратно");
//   }
//    else
//    {
//     Console.Write(b + ", ");
//     Console.WriteLine(a + " -> не кратно, остаток " + rem);
//    } 
// }
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// MultiNum(num1, num2);


// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет;
// 161 -> да

// void NumDiv(int a)
// {
//  if (a % 7 == 0 && a % 23 ==0)
//  {
//     Console.WriteLine(a + " -> " + "да");
//  }
//  else
//  {
//     Console.WriteLine(a + " -> " + "нет"); 
//  }
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// NumDiv(num);


// 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// 25, 5 -> да
// 8, 9 -> нет

// void Square(int a, int b)
// {
//  if (a == b * b)
//  {
//     Console.WriteLine(a + ", "+ b + " -> да");
//  }
//  else
//  {
//    if (b == a * a)
//    {
//     Console.WriteLine(a + ", "+ b + " -> да");
//    }
//    else
//    {
//     Console.WriteLine(a + ", "+ b + " -> нет");
//    }
//  }

// }
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Square(num1, num2);


// Home work
// 1. Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа.

// void SecondNum(int a)
// {
//     int b = (a / 10) % 10;
//     Console.WriteLine(a + " -> " + b);
// }
// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 || num > 999)
// {
//     Console.WriteLine("Некорректные данные");
// }
// else
// {
//   SecondNum(num);
// }


// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// void ThreeNum(int a)
// {
// if (Math.Abs(a) < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
//  while (Math.Abs(a) > 1000)
//  {
//    a = a / 10;
//  }
// int n = Math.Abs(a) % 10;
// Console.WriteLine(n);
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// ThreeNum(num);


// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// void Weekends(int day)
// {
//  if (day < 1 || day > 7)
//  {
//     Console.WriteLine("Введены некорректные данные");
//  }
//  else if (day == 6 || day == 7 )
//  {
//     Console.WriteLine("Выходной день");
//  }
//  else
//  {
//     Console.WriteLine("Рабочий день");
//  }
// }
// Console.WriteLine("Введите номер дня недели");
// int num = Convert.ToInt32(Console.ReadLine());
// Weekends(num);

