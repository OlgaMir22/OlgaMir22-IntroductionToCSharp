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

/*
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
        Console.WriteLine ( $"Matrix sizes {m} or {n} or {k} are not a valid." );
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
}*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
{
    int [,,] generate3dIntUniqueArray ( int m, int n, int k )
    {
        int [] hist = new int [100];
        for ( int i = 0; i < hist.Length; ++i )
            hist [i] = 0;

        Random rnd = new Random ();

        int [,,] result = new int [m, n, k];
        for ( int x = 0; x < result.GetLength (0); ++x )
        {
            for ( int y = 0; y < result.GetLength (1); ++y )
            {
                for ( int z = 0; z < result.GetLength (2); ++z )
                {
                    do
                    {
                        result [x, y, z] = rnd.Next ( 0, 100 );
                    }
                    while ( hist [ result [x, y, z] ] != 0 );
                    ++hist [ result [x, y, z] ];
                }
            }
        }

        return result;
    }

    void print3dIntArray ( int [,,] arr )
    {
        for ( int x = 0; x < arr.GetLength (0); ++x )
        {
            for ( int y = 0; y < arr.GetLength (1); ++y )
            {
                for ( int z = 0; z < arr.GetLength (2); ++z )
                {
                    int value = arr [x, y, z];
                    Console.Write ( $"{value} ({x}, {y}, {z}) " );
                }
                Console.WriteLine ( "" );
            }
        }
    }
 
    Console.WriteLine ( "Task 60" );

    Console.Write ( "Input array size m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input array size n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input array size k: " );
    int k = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 || k <= 0 )
        Console.WriteLine ( $"Array sizes {m} or {n} or {k} are not a valid." );
    if ( m * n * k > 100 )
        Console.WriteLine ( $"Array with sizes {m}, {n}, {k} exceeds 100 unique elements." );
    else
    {
        int [,,] arr = generate3dIntUniqueArray ( m, n, k );
        print3dIntArray ( arr );
    }
}
*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

{
    int [,] createIntZeroArray ( int m, int n )
    {
        int [,] result = new int [m, n];
        for ( int i = 0; i < m; ++i )
        {
            for ( int j = 0; j < n; ++j )
                result [i, j] = 0;
        }

        return result;
    }

    int stepArrayFrom ( ref int [,] arr, ref int x, ref int y, ref int index, int stepX, int stepY )
    {
        int stepsCount = 0;
        do
        {
            int newX = x + stepX;
            int newY = y + stepY;

            //Console.WriteLine ( $"{newX}, {newY}" );

            if ( newX < 0 || newX >= arr.GetLength ( 0 ) )
                return stepsCount;
            
            if ( newY < 0 || newY >= arr.GetLength ( 1 ) )
                return stepsCount;

            if ( arr [newX, newY] != 0 )
                return stepsCount;

            ( x, y ) = ( newX, newY );

            arr [x, y] = ++index;
            ++stepsCount;
        }   
        while (true);
    }

    void fillSpiralArray ( ref int [,] arr )
    {
        int x = 0, y = 0, index = 1;
        arr [x, y] = index;
        do 
        {
            if ( stepArrayFrom ( ref arr, ref x, ref y, ref index, 0, 1 ) == 0 ) 
                return;

            if ( stepArrayFrom ( ref arr, ref x, ref y, ref index, 1, 0 ) == 0 ) 
                return;
            
            if ( stepArrayFrom ( ref arr, ref x, ref  y, ref index, 0, -1 ) == 0 ) 
                return;
            
            if ( stepArrayFrom ( ref arr, ref x, ref  y, ref index, -1, 0 ) == 0 ) 
                return;
        }
        while ( true );
    }

    void printInt2dArray2Digits ( int [,] arr )
{
    for ( int i = 0; i < arr.GetLength (0); ++i )
    {
        for ( int j = 0; j < arr.GetLength (1); ++j )
            Console.Write ( arr [i, j].ToString ( "00" ) + " " );
        Console.WriteLine ( "" );
    }
}

    Console.WriteLine ( "Task 62" );

    Console.Write ( "Input row count m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input col count n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 || n <= 0 )
        Console.WriteLine ( $"Row count {m} or col count {n} is not a valid." );
    else
    {
        int [,] arr = createIntZeroArray ( m, n );
        fillSpiralArray ( ref arr );
        printInt2dArray2Digits ( arr );
    }
}