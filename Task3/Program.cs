//Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void FindDayOfWeek (int n) // метод по введеному числу выводит день недели
{
if (n <= 5)
{
    Console.WriteLine("It is not a day off!(");
}
if (n == 6 || n == 7)
{
    Console.WriteLine("It is a day off!");
}
else
{
    if (n>7)
    {
        Console.WriteLine("It is not correct number!");
    }
}
}

Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

FindDayOfWeek(num);

