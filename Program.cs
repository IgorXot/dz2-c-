/----------------------------------------DZ2----------------------------------------------

//1. Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Second(int num)
{
        int duonum = num / 10 % 10;
        return duonum;  
}
Console.Write("Enter three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNum = Second(num);
Console.WriteLine($"Second Number version a Number {num} is {secondNum}");
*/


/* 1.1 Другой вариант. 
int Second(int num)
{
    if(num >= 100 && num <= 999)
    {
        int duonum = num / 10 % 10;
        return duonum;
    }
    else
    {
        return -1;
    }
}
Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNum = Second(num);
Console.WriteLine($"Second Number version a number {num} is {secondNum}");
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNum(int num)
{
    if(num > 99)
    {
        while(num > 1000) 
        {
            num = num / 10;
        }
        int ThirdNum = num % 10;
        return ThirdNum;
    }
    else
    {
        return -1;
    }    
} 
Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = ThirdNum(num);
Console.WriteLine($"Third Number version a number {num} is {newNum}");
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool Day(int count)
{
    
    if(count == 6) return true;
    if(count == 7) return true;
    else 
    return false;
}
Console.Write("Enter а number from 1 to 7: ");
int countDay = Convert.ToInt32(Console.ReadLine());
bool reply  = Day(countDay);
Console.WriteLine(reply);