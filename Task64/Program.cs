﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int M, int N)
{
    if (N < M) return;
    ShowNumbers(M + 1, N);
    Console.Write(M + " ");
}


Console.Clear();
int M = 1;
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
ShowNumbers(M, N);