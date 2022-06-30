// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
using MyLibs;
Clear();

Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(ReadLine());

int[,] arr = new int[m, n];
MyMetods.GetRandomArrayInt(arr);
MyMetods.PrintArrayInt(arr);
WriteLine($"{String.Join("; ", MeanArithmetic(arr))}");

double[] MeanArithmetic(int[,] array)
{
   double[] arr = new double[array.GetLength(1)];
   double sum;
   for (int j = 0; j < array.GetLength(1); j++)
   {
      sum = 0;
      for (int i = 0; i < array.GetLength(0); i++)
      {
         sum += array[i, j];
      }
      arr[j] = sum / array.GetLength(0);
   }
   return arr;
}