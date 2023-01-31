//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = numberRequest("Введите число:");


if(number<=5 && number>=1)
{
    Console.WriteLine("Нет!");
}
else if(number>=6 && number<=7)
{
 Console.WriteLine("Да!");
 }

else Console.WriteLine("Как вы знаете, в неделе всего 7 дней");