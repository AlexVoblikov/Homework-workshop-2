//Задача № 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели от 1 до 7, где 1 это понедельник а 7 воскресенье: ");

int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 1 || digit > 7) 
{
Console.WriteLine("Вы ввели число, которое выходит за диапазон от 1 до 7 ");
return;
}

if  (digit == 6 | digit == 7)
{
Console.WriteLine("Поздравляю, сегодня выходной!");
return;
}

if (digit != 1 | digit !<= 5)
{
Console.WriteLine("Сегодня будний день!");
return;
}
