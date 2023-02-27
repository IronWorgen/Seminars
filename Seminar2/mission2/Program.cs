// See https://aka.ms/new-console-template for more information
int num =  new Random().Next(100,1000);
Console.WriteLine(num);
int first_num = num / 100;
int last_num = num % 10;

Console.Write(first_num);
Console.Write(last_num);



