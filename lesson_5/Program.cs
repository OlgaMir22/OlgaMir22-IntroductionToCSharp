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
