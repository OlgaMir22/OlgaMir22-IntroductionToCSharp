//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
456 -> 5
782 -> 8
918 -> 1
*/

{
    int getSecondDigit ( int number )
    {
        if ( number < 100 || number > 999 )
            return -1;
        
        int numberMod10 = number / 10;
        int secondDigit = numberMod10 % 10;
        return secondDigit;
    }

    Console.WriteLine ( "Task 10" );

    Console.Write ( "Input number: " );
    int number = Convert.ToInt32 ( Console.ReadLine () );

    int secondDigit = getSecondDigit ( number );

    if ( secondDigit < 0 )
        Console.WriteLine ( "Number should contain three digits. No more, not less!" );
    else
        Console.WriteLine ( $"Second digit is {secondDigit}" );
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6
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

    Console.WriteLine ( "Task 13" );

    Console.Write ( "Input number: " );
    int number = Convert.ToInt32 ( Console.ReadLine () );

    int [] digits = numberToDigits ( number );

    if ( digits.Length < 3 )
        Console.WriteLine ( "There is not third digit." );
    else
        Console.WriteLine ( "The third digit is " + digits [2] );

}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
6 -> да
7 -> да
1 -> нет
*/

{
    bool[] weekends = new bool[] {false, false, false, false, false, true, true};

     Console.WriteLine ( "Task 15" );

    Console.Write ( "Input day number: " );
    int number = Convert.ToInt32 ( Console.ReadLine () );

    if ( number < 1 || number > 7 )
        Console.WriteLine ( "Wrong day of the week number " + number );
    else
        Console.WriteLine ( $"Day {number} of the week is weekend = " + ( weekends [number - 1] ? "yes" : "no" ) );
}