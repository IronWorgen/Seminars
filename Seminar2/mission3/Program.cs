﻿//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("введите первое число");
int num_1=  int.Parse(Console.ReadLine());

Console.Write("введите второе число");
int num_2=  int.Parse(Console.ReadLine());

if ( num_1 % num_2 == 0 )
{
    Console.Write("кратно");
}
else 
{
    Console.WriteLine(num_1 % num_2);
}
