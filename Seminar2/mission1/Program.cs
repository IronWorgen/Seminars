// See https://aka.ms/new-console-template for more information
int num =  new Random().Next(10,100);
Console.WriteLine(num);

int first_num = num / 10;
int second_num = num % 10;

if (first_num > second_num)
{
    Console.WriteLine(first_num);
}
else 
{
    Console.WriteLine(second_num);
}


