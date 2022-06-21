// 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат.
// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("Квадрат числа равен " + result);


// 2. Напишите программу, которая на входе принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num1 == square)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }


// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Console.WriteLine("Введите номер дня недели");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//    Console.WriteLine("Некорректные данные");
// }
// else
// {
//    if (day == 1)
//    {
//       Console.WriteLine("Понедельник");
//    }
//     if (day == 2)
//    {
//        Console.WriteLine("Вторник");
//    }
//     if (day == 3)
//    {
//        Console.WriteLine("Среда");
//    }
//     if (day == 4)
//    {
//        Console.WriteLine("Четверг");
//    }
//     if (day == 5)
//    {
//        Console.WriteLine("Пятница");
//    }
//     if (day == 6)
//    {
//        Console.WriteLine("Суббота");
//    }
//     if (day == 7)
//    {
//        Console.WriteLine("Воскресенье");
//    }
// }


// 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N.
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0)
// {
//     current = num;
//     num = num * (-1);
// }
// else
// {
//     current = -1 * num;
// }
// while (current < num - 1)
// {
//     current = current + 1;
//     Console.Write(current + " ");    
// }


// 5. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num % 10);


// Home Work

// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int min;
// int max;

// if (num1 < num2)
// {
//     min = num1;
//     max = num2;
// }
// else
// {
//     min = num2;
//     max = num1;
// }
// Console.WriteLine("Минимальное число " + min);
// Console.WriteLine("Максимальное число " + max);


// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.WriteLine("max = " + max);


// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine(num + " - чётное число");
// }
// else
// {
//     Console.WriteLine(num + " - нечётное число");
// }


// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int num = 1;
// while (num < N)
// {
// if (num % 2 == 0)
// {
//     Console.Write(num + " ");
// }
// num = num + 1;
// }




