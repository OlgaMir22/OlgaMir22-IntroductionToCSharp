﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] generateInt2dArray ( int m, int n, int min_val, int max_val )
{
    int [,] array = new int [m, n];

    Random rnd = new Random ();
    for ( int i = 0; i < m; ++i )
    {
        for ( int j = 0; j < n; ++j )
            array [i, j] = rnd.Next ( min_val, max_val + 1 );
    }

    return array;
}

void printInt2dArray ( int [,] arr )
{
    for ( int i = 0; i < arr.GetLength (0); ++i )
    {
        for ( int j = 0; j < arr.GetLength (1); ++j )
            Console.Write ( arr [i, j] + " " );
        Console.WriteLine ( "" );
    }
}
/*
{
    int [,] sortArrayRows ( int [,] arr )
    {
        for ( int i = 0; i < arr.GetLength (0); ++i )
        {
            for ( int j = 0; j < arr.GetLength (1) - 1; ++j )
            {
                for ( int k = 0; k < arr.GetLength (1) - 1 - j; ++k )
                    if ( arr [i, k] < arr [i, k + 1] )
                           ( arr [i, k], arr [i, k + 1] ) = ( arr [i, k + 1], arr [i, k] );
            }
        }   

        return arr;
    }

    Console.WriteLine ( "Task 54" );

    Console.Write ( "Input row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 )
        Console.WriteLine ( $"Row count {m} or col count {n} is not a valid." );
    else
    {
        int [,] arr = generateInt2dArray ( m, n, 0, 9 );
        Console.WriteLine ( "Source array: " );
        printInt2dArray ( arr );

        arr = sortArrayRows ( arr );
        Console.WriteLine ( "Result array: " );
        printInt2dArray ( arr );
    }
}*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
{   
    int [] calcRowsSums ( int [,] arr )
    {
        int [] rowsSums = new int [arr.GetLength (0)];
        for ( int i = 0; i < arr.GetLength (0); ++i )
        {
            rowsSums [i] = 0;
            for ( int j = 0; j < arr.GetLength (1); ++j )
                rowsSums [i] += arr [i, j];
        }

        return rowsSums;
    }    

    int findMinIndex ( int [] arr )
    {
        int minIndex = 0;
        int minValue = arr [0];

        for ( int i = 1; i < arr.GetLength (0); ++i )
        {
            if ( arr [i] < minValue )
            {
                minValue = arr [i];
                minIndex = i;
            }
        }
        return minIndex;
    }

    void printArray ( int [] arr )
    {
        Console.Write ( "[" );
        
        for ( int i = 0; i < arr.Length - 1; ++i )
            Console.Write ( arr [i] + ", " );
        Console.Write ( arr [arr.Length - 1] );

        Console.Write ( "]" );
    }    

    Console.WriteLine ( "Task 56" );

    Console.Write ( "Input row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 )
        Console.WriteLine ( $"Row count {m} or col count {n} is not a valid." );
    else
    {
        int [,] arr = generateInt2dArray ( m, n, 0, 9 );
        Console.WriteLine ( "Source array: " );
        printInt2dArray ( arr );

        int [] rowsSums = calcRowsSums ( arr );
        Console.Write ( "Rows sums are: " );
        printArray ( rowsSums );
        Console.WriteLine ( "" );

        int minRowIndex = findMinIndex ( rowsSums );
        Console.Write ( $"Row index with minimal items : {minRowIndex}" );
    }
}*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
{
    int [,] multiply ( int [,] a, int [,] b )
    {
        int resultRows = a.GetLength (0);
        int resultCols = b.GetLength (1);
        int [,] result = generateInt2dArray ( resultRows, resultCols, 0, 0 );
        for ( int i = 0; i < result.GetLength (0); ++i )
        {
            for ( int j = 0; j < result.GetLength (1); ++j )
            {
                for ( int k = 0; k < a.GetLength (1); ++k )
                {
                    result [ i, j ] += a [i, k] * b [k, j];
                }
            }
        }

        return result;
    }

    Console.WriteLine ( "Task 58" );

    Console.Write ( "Input result row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input result col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input first matrix col count and second matrix row count k: " );
    int k = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 || k <= 0 )
        Console.WriteLine ( $"Row matrix sizes {m} or {n} or {k} are not a valid." );
    else
    {
        int [,] a = generateInt2dArray ( m, k, 0, 9 );
        Console.WriteLine ( "A matrix: " );
        printInt2dArray ( a );

        int [,] b = generateInt2dArray ( k, n, 0, 9 );
        Console.WriteLine ( "B matrix: " );
        printInt2dArray ( b );

        int [,] result = multiply ( a, b );
        Console.WriteLine ( "Matrix product: " );
        printInt2dArray ( result );
    }
}