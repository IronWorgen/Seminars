﻿//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Write("введите число  ");
int num=  int.Parse(Console.ReadLine());

if (num % 7 == 0  & num % 23 == 0 )

{
    Console.Write("да");
}
else 
{
    Console.Write("нет");
}