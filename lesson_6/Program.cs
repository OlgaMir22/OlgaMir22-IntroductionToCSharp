/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

{
    int [] readArray ( int M )
    {
        Console.WriteLine ( "Input numbers:" );

        int [] result = new int [M];
        for ( int i = 0; i < M; ++i )
            result [i] = Convert.ToInt32 ( Console.ReadLine () );

            return result;
    }

    int countPositives ( int [] arr )
    {
        int positives = 0;
        for ( int i = 0; i < arr.Length; ++i )
            if ( arr [i] > 0 ) ++positives; 
        return positives;
    }

    Console.WriteLine ( "Task 41" );

    Console.Write ( "Input numbers count M: " );
    int M = Convert.ToInt32 ( Console.ReadLine () );

    if ( M <= 0 )
        Console.WriteLine ( $"Power {M} is not a valid numbers count." );
    else
    {
        int [] arr = readArray ( M );
        int positives = countPositives ( arr );

        Console.WriteLine ( $"You have entered {positives} positive numbers." );
    }
}

