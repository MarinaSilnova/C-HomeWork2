// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int DayOfTheWeekNumber()
{
    Console.Write("Введите число от 1 до 7 "); 
    int n = Convert.ToInt32(Console.ReadLine());
    while(n < 1 || n > 7)
    {
        Console.Write(" Repeat, please: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}
void DayOFF()
{
int n = DayOfTheWeekNumber();
int monday = 1;
int tuesday = 2;
int wednesday = 3;
int tuersday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;
if (n == saturday || n == sunday)
    Console.WriteLine("выходной");
else
    Console.WriteLine("нет");
}
DayOFF();


