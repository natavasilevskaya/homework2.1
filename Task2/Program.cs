/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
на данном этапе программа работает только с целыми положительными числами, потому что на выходе тип данных - 
// cтрока -> выводится символ, а не численное значение = минимальное возможное решение
чтобы работать с отрицательными числами -использовать тип int/конвертацию (пока не разобралась) */

void ThirdDigit(string number)
{
if (number.Length >= 3)
{
    char thirdChar = number[2];
    Console.WriteLine("Third digit is " + thirdChar);
}

else
{
    if (number.Length == 2)
    {
        Console.WriteLine(number + "does not have a third digit, it is a two digit number!");
    }
    if (number.Length == 1)
    {
        Console.WriteLine(number + "does not have a third digit, it is a one digit number!");
    }

}

}

string number1;
Console.Write("Input your number: ");
number1 = Console.ReadLine();
ThirdDigit(number1);
