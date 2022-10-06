// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
{
    Console.WriteLine ( "Task 2" );

    Console.Write ( "Input first number: " );
    int a = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input second number: " );
    int b = Convert.ToInt32 ( Console.ReadLine () );

    if ( a > b )
    {
        Console.WriteLine ( $"The first number is greater. Max = {a}" );
    }
    else if ( a < b )
    {
        Console.WriteLine ( $"The second number is greater. Max = {b}" );
    }
    else
    {
        Console.WriteLine ( $"First and second numbers are equal. Max = {a}" );
    }
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

{
    Console.WriteLine ( "Task 4" );

    Console.Write ( "Input first number: " );
    int a = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input second number: " );
    int b = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input third number: " );
    int c = Convert.ToInt32 ( Console.ReadLine () );

    if ( a > b && a > c )
    {
        Console.WriteLine ( $"The first number is maximal. Max = {a}" );
    }
    else if ( b > a && b > c )
    {
        Console.WriteLine ( $"The second number is maximal. Max = {b}" );
    }
    else if ( c > a && c > b )
    {
        Console.WriteLine ( $"The third number is maximal. Max = {c}" );
    }
    else if ( c == a && c > b )
    {
        Console.WriteLine ( $"First and third are maximals. Max = {a}" );
    }
    else if ( b == a && b > c )
    {
        Console.WriteLine ( $"First and second are maximals. Max = {a}" );
    }
    else if ( b == c && b > a )
    {
        Console.WriteLine ( $"Second and third are maximals. Max = {b}" );
    }
    else
    {
        Console.WriteLine ( $"All three are maximals. Max = {b}" );
    }
}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/

{
    Console.WriteLine ( "Task 6" );

    Console.Write ( "Input number: " );
    int a = Convert.ToInt32 ( Console.ReadLine () );

    int b = a % 2;

    if ( b == 0 )
    {
        Console.WriteLine ( "Number is even." );
    }
    else
    {
        Console.WriteLine ( "Number is odd." );
    }
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

{
    Console.WriteLine ( "Task 8" );

    Console.Write ( "Input number N: " );
    int N = Convert.ToInt32 ( Console.ReadLine () );

    if ( N < 1 )
    {
        Console.WriteLine ( "N should be > 1!" );
    }
    else
    {
        int i = 1;

        while ( i <= N )
        {
            int b = i % 2;

            if ( b == 0 )
            {
                Console.Write ( $"{i} " );
            }
            ++i;
        }
    }
}