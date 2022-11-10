// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных
// [345, 897, 568, 234] -> 2

// int[] GetArray(int size)                           // Создание массива с рандомными числами от 100 до 999
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(100, 1000);
//     }
//     return result;
// }

// int SumEvenNumbers(int[] getarray)               // Находим четные числа и считаем их количество
// {
//     int sum = 0;
//     for (int i = 0; i < getarray.Length; i++)
//     {
//         if (getarray[i] % 2 == 0)
//         {
//             sum++;
//         }
//     }
//     return sum;
// }
// Console.Clear();
//  Console.WriteLine($"Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных.");
// Console.Write($"Введите размер массива ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(num);
// Console.WriteLine($"[{String.Join(", ", array)}] -> {SumEvenNumbers(array)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GetArray(int size)                                    // Создание массива с рандомными числами от -99 до 99
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-99, 100);
//     }
//     return result;
// }

// int SumOddNumbers(int[] getarray)                          // Находим сумму чисел на нечетных позициях
// {
//     int sum = 0;
//     for (int i = 1; i < getarray.Length; i += 2)
//     {
//         sum += getarray[i];
//     }
//     return sum;
// }

// Console.Clear();
// Console.WriteLine($"Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
// Console.Write($"Введите размер массива ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(num);
// Console.WriteLine($"[{String.Join(", ", array)}] -> {SumOddNumbers(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] GetArray(int size)                          // Создание массива с рандомными дробными числами от -99,99 до 99,99
// {
//     double[] result = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = Convert.ToDouble(new Random().Next(-9999, 10000)) / 100;
//     }
//     return result;
// }

// double Difference(double[] getarray)                 // проверка массива на Max и Min значения и составление разницы между ними
// {
//     double dif = 0;
//     double max = getarray[0];
//     double min = getarray[0];
//     for (int i = 0; i < getarray.Length; i++)
//     {
//         if (getarray[i] > max)
//         {
//             max = getarray[i];
//         }
//         else if (getarray[i] < min)
//         {
//             min = getarray[i];
//         }
//     }
//     if (max > 0 && min <= 0)
//     {
//         dif = max + Math.Abs(min);
//     }
//     else if (max >= 0 && min >= 0)
//     {
//         dif = max - min;
//     }
//     else
//     {
//         dif = Math.Abs(min) + max;
//     }
//     return dif;
// }

// Console.Clear();
// Console.WriteLine($"Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
// Console.Write($"Введите размер массива ");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] array = GetArray(num);
// Console.WriteLine($"[{String.Join("  ", array)}] -> {Math.Round(Difference(array), 2)}");    // прибавил math.round так как в некоторых выражениях получалось большое количество знаков после запятой