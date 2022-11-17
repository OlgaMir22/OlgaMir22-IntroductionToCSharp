/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

{
    void printNaturalNumber ( int n )
    {
        if ( n > 1 )
        {
            Console.Write ( $"{n}, " );
            printNaturalNumber ( n - 1 );
        }
        else
        if ( n == 1 )
            Console.Write ( n ); 

    }

    Console.WriteLine ( "Task 64" );

    Console.Write ( "Input number N: " );
    int N = Convert.ToInt32 ( Console.ReadLine () );

    if ( N < 1 )
        Console.WriteLine ( "N should be a natural number." );
    else
    {
        Console.Write ( $"N = {N} -> \"" );
        
        printNaturalNumber ( N );

        Console.WriteLine ( "\"" );
    }
}

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

{
    int rangedSum ( int from, int to )
    {
        if ( from == to )
            return to;
        else
            return from + rangedSum ( from + 1, to );
    }

    Console.WriteLine ( "Task 66" );

    Console.Write ( "Input number M: " );
    int M = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input number N: " );
    int N = Convert.ToInt32 ( Console.ReadLine () );

    if ( M > N )
    {
        Console.WriteLine ( $"Number M = {M} should be less then N = {N}. Swapped M and N." );
        ( M, N ) = ( N, M );
    }

    if ( M < 1 )
        Console.WriteLine ( "M should be a natural number." );
    else
    {
        int sum = rangedSum ( M, N );
        Console.WriteLine ( $"M = {M}; N = {N} -> {sum}" );
    }
}