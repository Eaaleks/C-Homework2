//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest("Введите число:");

// показать вторую цифру числа
int ShowSecondDigit (int number)
{                                 
    int SecondDigit = ((number / 10) % 10);
    return SecondDigit;
}

int SecondDigit = ShowSecondDigit(number);

Console.WriteLine(SecondDigit);