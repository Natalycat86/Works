// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int [] num = {1,2,3,4,5};
// int [] num2 = new int [num.Length];
// int count = num.Length-1;
// for (int i = 0; i < num.Length; i++)
// {
//     num2 [count] = num [i];
// count--;
// Console.Write (num[i]);
// }
// Console.WriteLine();
// for (int i = 0; i < num2.Length; i++)
// Console.Write (num2[i]);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите длину первой стороны треугольника: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину второй стороны треугольника: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину третьей стороны треугольника: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if(num<num2+num3 && num2<num+num3 && num3<num+num2) Console.WriteLine("Треугольник");
// else Console.WriteLine("Не является треугольником");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num > 0)
// {
//     if (num%2 == 0)
// Console.Write(0);
// else 
// Console.Write(1);
// num = num/2;
// }
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// void task4()
// {
//     Console.Write("Введите число: ");
//     int N = int.Parse(Console.ReadLine());
    
//     int N_1 = 1;
//     int N_2 = 0;

//     Console.Write($"{N_2} {N_1}");

//     for (int i = 1; i < N - 1; i++)
//     {
//         Console.Write($"{N_2 + N_1} ");
//         int b = N_1;
//         N_1 = N_2 + N_1;
//         N_2 = b;
//     }
//     Console.WriteLine("\n\n");
// }

// void task5()
// {
//     Console.Write("Введите размерность массива: ");

//     int SIZE = int.Parse(Console.ReadLine());
//     int[] arr = new int[SIZE];

//     f_arr(arr);
//     write_arr(arr);

//     Console.WriteLine("\n\n");

//     int[] arr_2 = new int[SIZE];
    
//     for (int i = 0; i < SIZE; i++)
//     {
//         arr_2[i] = arr[i];
//     }

//     write_arr(arr_2);
// }
// void f_arr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,200);
//     }
// }

// void write_arr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
