/*Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

/*
int SecondNumber (int num)
{
    int one = num/10;
    return one%10;
}

Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32 (Console.ReadLine());
int result = SecondNumber (N);
Console.WriteLine (result);
*/


/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


/*void ThirdNumber (int num)
{
    int sot = num/100;
    if(sot==0)
    {
       Console.WriteLine($"Увы, но это число не трехзначное...");
    }
    else
    {
        int result = num%10;
        Console.WriteLine($"{result}");
    }
    
}

Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32 (Console.ReadLine());
ThirdNumber (N);
*/

/*Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

/*void Week (int day)
{
    if (day==1||day==2||day==3||day==4||day==5)
    {
        Console.WriteLine($"Нет, это не выходной");
    }
    if (day==6||day==7)
    {
        Console.WriteLine($"О да, это выходной!!!");
       
    }
    if (day>7)
    Console.WriteLine($"Ой, в неделе всего семь дней)");
    
}

Console.WriteLine("Введите число, обозначающее номер дня недели");
int D = Convert.ToInt32 (Console.ReadLine());
Week (D);
*/