// Задача № 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначный номер: ");

int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 100 || digit > 999) 
{
Console.WriteLine("Вы ввели не 3 значное число");
return;
}


int digitFirst = digit / 100;
int digitSecond = digit % 10;
Console.WriteLine($"{digitSecond}");
