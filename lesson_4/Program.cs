/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

{
    double myPow ( int A, int B )
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
        Console.WriteLine ( myPow ( A, B ) );
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

{
    int [] numberToDigits ( int number )
    {
        int[] digits = new int[1 + ( int ) Math.Log10 ( number )];
        for (int i = digits.Length - 1; i >= 0; --i)
        {
            int digit;
            number = Math.DivRem ( number, 10, out digit );
            digits[i] = digit;
        }
        return digits;
    }

    int numbersSum ( int [] numbers )
    {
        int sum = 0;
        for ( int i = 0; i < numbers.Length; ++i )
            sum = sum + numbers [i];
        return sum;
    }

    Console.WriteLine ( "Task 27" );

    Console.Write ( "Input a number: " );
    int number = Convert.ToInt32 ( Console.ReadLine () );

    int digitsSum = numbersSum ( numberToDigits ( number ) );

    Console.WriteLine ( $"Digits sum in number {number} is {digitsSum}." );
}


/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
m = 5 -> [1, 2, 5, 7, 19]
m = 3 -> [6, 1, 33]
*/

{
    int [] generateArray ( int m )
    {
        Random rnd = new Random ();

        int [] arr = new int [m];
        for ( int i = 0; i < m; ++i )
            arr [i] = rnd.Next ( 100 );

        return arr;
    }

    void outputArray ( int [] arr )
    {
        Console.Write ( "[" );
        
        for ( int i = 0; i < arr.Length - 1; ++i )
            Console.Write ( arr [i] + ", " );
        Console.Write ( arr [arr.Length - 1] );

        Console.WriteLine ( "]" );
    }

    Console.WriteLine ( "Task 29" );

    Console.Write ( "Input array length m: " );
    int m = Convert.ToInt32 ( Console.ReadLine () );

    if ( m <= 0 )
        Console.WriteLine ( $"Power {m} is not a valid array length." );
    else
    {
        int [] array = generateArray ( m );
        outputArray ( array );
    }
}