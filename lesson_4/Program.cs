/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

{
    double MyPow ( int A, int B )
    {
        double result = 1.0; 
        for ( int i = 1; i <= B; ++i )
            result = result * A;
        return result;
    }

    Console.WriteLine ( "Task 25" );

    Console.Write ( "Input base number A: " );
    int A = Convert.ToInt32 ( Console.ReadLine () );

    Console.Write ( "Input natural power B: " );
    int B = Convert.ToInt32 ( Console.ReadLine () );

    if ( B <= 0 )
        Console.WriteLine ( $"Power {B} is not a natural number." );
    else
        Console.WriteLine ( MyPow ( A, B ) );
}