﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введие число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);

if (a % 2 == 0) 
{
    Console.WriteLine("Четное");
}
else Console.WriteLine("Нечетное");