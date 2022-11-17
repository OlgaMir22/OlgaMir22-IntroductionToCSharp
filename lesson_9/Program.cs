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