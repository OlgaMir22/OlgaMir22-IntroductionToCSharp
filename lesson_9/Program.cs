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

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

{
    int Ackermann ( int m, int n )
    {
        if ( m == 0 )
            return n + 1;
        else if ( m > 0 && n == 0 )
            return Ackermann ( m - 1, 1 );
        else
            return Ackermann ( m - 1, Ackermann ( m, n - 1 ) );
    }

    Console.WriteLine ( "Task 68" );

    Console.Write ( "Input number m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input number n: " );
    int n = Convert.ToInt32 ( Console.ReadLine () );

    if ( m < 0 )
        Console.WriteLine ( "m should be a non-negative number." );
    else if ( n < 0 )
        Console.WriteLine ( "n should be a non-negative number." );
    else
    {
        int A = Ackermann ( m, n );
        Console.WriteLine ( $"m = {m}; n = {n} -> A ( m, n ) = {A}" );
    }
}