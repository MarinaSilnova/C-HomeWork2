﻿//задача 10 вариант решения 2. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int ThreeDigitNumber()
{
    Console.WriteLine("Введите 3-х значное число");
    int n = Convert.ToInt32(Console.ReadLine());
    while(n < 100 || n > 999)
    {
        Console.Write(" Repeat, please: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}
void SecondDigit()
{
    int n = ThreeDigitNumber();
    Console.Write(Convert.ToString(n)[1]);
}
SecondDigit();
