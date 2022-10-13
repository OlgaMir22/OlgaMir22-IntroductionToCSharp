/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
{
    Console.WriteLine ( "Task 19" );

    Console.Write ( "Input 5-digits number:" );
    string number = Console.ReadLine ();

    try {
        int num = Convert.ToInt32 ( number );
    }
    catch ( FormatException ) {
        Console.WriteLine ( $"The value '{number}' is not a number." );
        return;
    }

    if ( number.Length != 5 )
        Console.WriteLine ( "Input is not a 5-digits number." );
    else
    {
        bool is_polyndrom = true;
        for ( int i = 0; i < number.Length / 2; ++i )
            is_polyndrom = is_polyndrom && ( number [i] == number [number.Length - i - 1] );

        if ( is_polyndrom )
            Console.WriteLine ( $"Number {number} is a polyndrom" );
        else
            Console.WriteLine ( $"Number {number} is NOT a polyndrom" );
    }
}*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

{
    Console.WriteLine ( "Task 21" );

    Console.Write ( "Input point one x coord: " );
    int x1 = Convert.ToInt32 ( Console.ReadLine () );
    Console.Write ( "Input point one y coord: " );
    int y1 = Convert.ToInt32 ( Console.ReadLine () );
    Console.Write ( "Input point one z coord: " );
    int z1 = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input point two x coord: " );
    int x2 = Convert.ToInt32 ( Console.ReadLine () );
    Console.Write ( "Input point two y coord: " );
    int y2 = Convert.ToInt32 ( Console.ReadLine () );
    Console.Write ( "Input point two z coord: " );
    int z2 = Convert.ToInt32 ( Console.ReadLine () );

    int dx = ( x2 - x1 ),
        dy = ( y2 - y1 ),
        dz = ( z2 - z1 );
    double dist = Math.Sqrt ( dx * dx + dy * dy + dz * dz );
    Console.WriteLine ( "The distance in 3D space is: " + Math.Round ( dist, 2 ) );
}