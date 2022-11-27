﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2dArray(int rows, int columns)
// {
//     int[,] createdArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             createdArray[i, j] = new Random().Next(0, 10);
//     return createdArray;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] SortElemRows (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = j + 1; k < array.GetLength(1); k++)
//                 if (array[i, k] > array[i, j])
//                 {
//                     int temp = array[i,j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//     return array;
// }

// int [,] randArray = Create2dArray(3, 4);
// Show2dArray(randArray);
// Show2dArray(SortElemRows(randArray));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Create2dArray(int rows, int columns)
{
    int[,] createdArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i, j] = new Random().Next(0, 10);
    return createdArray;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Show1dArray (int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i] + " ");
        Console.WriteLine();
}

int [] FindSumElemRow(int [,] array)
{
    int [] sumRowArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        sumRowArray[i] = sum;
    }
    return sumRowArray;
}

int FindMinSumIndex (int [] array)
{
    int iMin = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[iMin]) iMin = i;
    return iMin;    
}

int [,] rand2dArray = Create2dArray(3, 4);
Show2dArray (rand2dArray);
int [] sumElemRows = FindSumElemRow(rand2dArray);
Show1dArray(sumElemRows);
Console.WriteLine($"Sum of elem in rows is min in row {FindMinSumIndex(sumElemRows)}");


// Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




// Задача 60.(дополнительно) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07