// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("введите первое число");
int num_1=  int.Parse(Console.ReadLine());

Console.Write("введите второе число");
int num_2=  int.Parse(Console.ReadLine());

if (num_1*num_1 ==  num_2 | num_2*num_2 == num_1 )
{
    Console.WriteLine("да");
}
else{
Console.WriteLine("нет");
}

Console.Write($"{num_1}{num_2}");

