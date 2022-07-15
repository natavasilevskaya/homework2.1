// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondDigit (int n)
{
    int twodig = n/10;
    int result = twodig % 10;
    Console.WriteLine("Second digit is" + result);
}

Console.WriteLine("Input three digit number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

SecondDigit(n1);