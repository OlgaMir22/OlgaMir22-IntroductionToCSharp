int [] generateArray ( int size, int from_value, int to_value )
{
    Random rnd = new Random ();
    int range = to_value - from_value;

    int [] arr = new int [size];
    for ( int i = 0; i < size; ++i )
        arr [i] = rnd.Next ( range ) + from_value;

    return arr;
}

void outputArray ( int [] arr )
{
    Console.Write ( "[" );
    
    for ( int i = 0; i < arr.Length - 1; ++i )
        Console.Write ( arr [i] + ", " );
    Console.Write ( arr [arr.Length - 1] );

    Console.Write ( "]" );
}

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

{

    int countEvens ( int [] arr )
    {
        int evens = 0;
        for ( int i = 0; i < arr.Length; ++i )
            if ( arr [i] % 2 == 0 )
                ++evens;
        return evens;
    }

    Console.WriteLine ( "Task 34" );

    Console.Write ( "Input array length N: " );
    int N = Convert.ToInt32 ( Console.ReadLine () );

    if ( N <= 0 )
        Console.WriteLine ( $"Power {N} is not a valid array length." );
    else
    {
        int [] array = generateArray ( N, 100, 999 );
        outputArray ( array );

        int evens = countEvens ( array );
        Console.WriteLine ( $" contains {evens} even items." );
    }
}

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

{

    int sumOddItems ( int [] arr )
    {
        int oddsSum = 0;
        for ( int i = 0; i < arr.Length; ++i )
            if ( i % 2 == 1 )
                oddsSum = oddsSum + arr [i];
        return oddsSum;
    }

    Console.WriteLine ( "Task 36" );

    Console.Write ( "Input array length N: " );
    int N = Convert.ToInt32 ( Console.ReadLine () );

    if ( N <= 0 )
        Console.WriteLine ( $"Power {N} is not a valid array length." );
    else
    {
        int [] array = generateArray ( N, -100, 100 );
        outputArray ( array );

        int oddsSum = sumOddItems ( array );
        Console.WriteLine ( $" has summ of odd items equal to {oddsSum}." );
    }
}

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

{
    float [] generateFloatArray ( int size, int from_value, int to_value )
    {
        Random rnd = new Random ();
        int range = to_value - from_value;

        float [] arr = new float [size];
        for ( int i = 0; i < size; ++i )
            arr [i] = rnd.Next ( range ) + from_value;

        return arr;
    }

    void outputFloatArray ( float [] arr )
    {
        Console.Write ( "[" );
        
        for ( int i = 0; i < arr.Length - 1; ++i )
            Console.Write ( arr [i] + ", " );
        Console.Write ( arr [arr.Length - 1] );

        Console.Write ( "]" );
    }

    float maximal ( float [] arr )
    {
        float max = arr [0];
        for ( int i = 1; i < arr.Length; ++i )
            max = Math.Max ( max, arr [i] );
        return max;
    }

    float minimal ( float [] arr )
    {
        float min = arr [0];
        for ( int i = 1; i < arr.Length; ++i )
            min = Math.Min ( min, arr [i] );
        return min;
    }

    Console.WriteLine ( "Task 38" );

    Console.Write ( "Input array length N: " );
    int N = Convert.ToInt32 ( Console.ReadLine () );

    if ( N <= 0 )
        Console.WriteLine ( $"Power {N} is not a valid array length." );
    else
    {
        float [] array = generateFloatArray ( N, 0, 100 );
        outputFloatArray ( array );

        float min_val = minimal ( array );
        float max_val = maximal ( array );
        float diff = max_val - min_val;
        Console.WriteLine ( $" has max = {max_val}, min = {min_val} and max-min = {diff}." );
    }
}