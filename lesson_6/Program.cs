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

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

{

    void inputLineParams ( out int k, out int b, int index )
    {
        Console.Write ( $"Input b{index}: " );
        b = Convert.ToInt32 ( Console.ReadLine () );

        Console.Write ( $"Input k{index}: " );
        k = Convert.ToInt32 ( Console.ReadLine () );
    }

    bool findX ( int k1, int b1, int k2, int b2, out float x )
    {
        float divisible = b2 - b1;
        int divisor = k1 - k2;

        bool result = ( divisor != 0 );

        if ( !result )
        {
            Console.Write ( "Lines are parallel, no intersections." );
            x = 0.0f;
        }
        else
            x = divisible / divisor;

        return result;
    }

    float solve ( int k1, float x, int b1 )
    {
        return k1 * x + b1;
    }

    Console.WriteLine ( "Task 43" );

    int k1 = 1, b1 = 0, k2 = 0, b2 = 0;
    inputLineParams ( out k1, out b1, 1 );
    inputLineParams ( out k2, out b2, 2 );

    float x = 0.0f;
    if ( findX ( k1, b1, k2, b2, out x ) )
    {
        float y = solve ( k1, x, b1 );
        Console.Write ( $"Intersection point is ({x}, {y})." );
    }
}
