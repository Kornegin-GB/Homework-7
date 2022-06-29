// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
using MyLibs;
Clear();

Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(ReadLine());

double[,] arr = new double[m, n];
MyMetods.GetRandomArrayDouble(arr);
MyMetods.PrintArrayDouble(arr);
