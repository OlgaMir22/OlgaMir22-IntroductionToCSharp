/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

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
}
