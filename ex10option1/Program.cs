// Задача 10 вариант решения первый;
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
    int a = n / 10;
    Console.WriteLine(a % 10);
}
SecondDigit();
