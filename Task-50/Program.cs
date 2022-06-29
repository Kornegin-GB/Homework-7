// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
using MyLibs;
Clear();

Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(ReadLine());

Write("Введите номе ряда для поиска: ");
int row = Convert.ToInt32(ReadLine());
Write("Введите номе колонки для поиска: ");
int column = Convert.ToInt32(ReadLine());

int[,] arr = new int[m, n];
MyMetods.GetRandomArrayInt(arr);
MyMetods.PrintArrayInt(arr);

if (row < m && row >= 0 && column < n && column >= 0)
{
   WriteLine($"Число в ряду {row} и столбце {column} -> {arr[row, column]}");
}
else
{
   WriteLine($"{row}, {column} -> Такого числа в массиве нет");
}
