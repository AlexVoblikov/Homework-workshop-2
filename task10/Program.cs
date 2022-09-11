// Задача № 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначный номер: ");

int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 100 || digit > 999) 
{
Console.WriteLine("Вы ввели не 3 значное число");
return;
}


int digitFirst = digit / 10;
int digitSecond = digitFirst % 10;
Console.WriteLine($"{digitSecond}");


