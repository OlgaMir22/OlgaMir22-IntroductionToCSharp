/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

{
    float [,] generateFloat2dArray ( int m, int n, int min_val, int max_val, int decimal_places )
    {
        float [,] array = new float [m, n];

        int divisor = Convert.ToInt32 ( Math.Pow ( 10, decimal_places ) );
        
        Random rnd = new Random ();
        for ( int i = 0; i < m; ++i )
        {
            for ( int j = 0; j < n; ++j )
                array [i, j] = ( rnd.Next ( min_val * divisor, ( max_val + 1 ) * divisor  ) * 1.0f ) / divisor;
        }

        return array;
    }

    void printFloat2dArray ( float [,] arr )
    {
        for ( int i = 0; i < arr.GetLength (0); ++i )
        {
            for ( int j = 0; j < arr.GetLength (1); ++j )
                Console.Write ( arr [i, j] + " " );
            Console.WriteLine ( "" );
        }
    }

    Console.WriteLine ( "Task 47" );

    Console.Write ( "Input row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 )
        Console.WriteLine ( $"Row count {m} or col count {n} is not a valid." );
    else
    {
        float [,] arr = generateFloat2dArray ( m, n, -9, 9, 2 );

        printFloat2dArray ( arr );
    }
}
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
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
    bool checkItemInt2dArray ( int [,] arr, int m, int n )
    {
        return m >= 0 && m < arr.GetLength (0) && n >= 0 && n < arr.GetLength (1);
    }

    Console.WriteLine ( "Task 50" );

    Console.Write ( "Input row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 )
        Console.WriteLine ( $"Row count {m} or col count {n} is not a valid." );
    else
    {
        int [,] arr = generateInt2dArray ( m, n, -9, 9 );
        printInt2dArray ( arr );

        Console.Write ( "Input row index i: " );
        int i = Convert.ToInt32 ( Console.ReadLine () );

        Console.Write ( "Input col index j: " );
        int j = Convert.ToInt32 ( Console.ReadLine () );

        if ( checkItemInt2dArray ( arr, i, j ) )
        {
            Console.WriteLine ( $"Item index ({i}, {j}) value = " + arr [i, j] );
        }
        else
        {
            Console.WriteLine ( $"Item index ({i}, {j}) not found in array" );
        }
    }
}

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

{
    float [] calcColAverages ( int [,] arr )
    {
        float [] avgs = new float [arr.GetLength (1)];

        for ( int j = 0; j < arr.GetLength (1); ++j )
        {
            float avg = 0.0f;
            for ( int i = 0; i < arr.GetLength (0); ++i )
                avg = avg + arr [i, j];
            avg = avg / arr.GetLength (0);
            avgs [j] = avg;
        }
        return avgs;
    }

    void outputFloatArray ( float [] arr )
    {
        Console.Write ( "[" );
        
        for ( int i = 0; i < arr.Length - 1; ++i )
            Console.Write ( arr [i] + "; " );
        Console.Write ( arr [arr.Length - 1] );

        Console.Write ( "]" );
    }

    Console.WriteLine ( "Task 52" );

    Console.Write ( "Input row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 )
        Console.WriteLine ( $"Row count {m} or col count {n} is not a valid." );
    else
    {
        int [,] arr = generateInt2dArray ( m, n, 0, 9 );
        printInt2dArray ( arr );

        float [] avgs = calcColAverages ( arr );
        Console.WriteLine ( "Column averages are:" );
        outputFloatArray ( avgs );
    }
}