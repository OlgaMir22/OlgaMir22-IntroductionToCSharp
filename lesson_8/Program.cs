/*
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
}