﻿/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет*/
/*
Console.WriteLine("Input number1:");
int number1 = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Input number2:");
int number2 = int.Parse(Console.ReadLine()!); 

if (number1 == number2 * number2)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
*/

/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/
/*
Console.WriteLine("Input number:");
int number1 = int.Parse(Console.ReadLine()!); 

if (number1 == 3)
    {
        Console.WriteLine("->Wednesday");
    }
    else if (number1 == 5 )
    {
        Console.WriteLine("->Friday");
    }
    else
        {
            Console.WriteLine("Unknown day!");
        }
*/

/*Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/
/*
Console.WriteLine("Input number N:");
int number = int.Parse(Console.ReadLine()!); 
int i = -number;
while (i <= number)
{
    Console.Write(i + " ");
    i++;
}
*/

/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/

Console.WriteLine("Input three digit number:");
int number = int.Parse(Console.ReadLine()!); 
if(100 <= number&&number < 1000)
{
    int result = number % 10;
    Console.Write(result);
}
else if(100 > number)
{
    Console.Write("Number too small!");
}
else {
    Console.Write("Number too large!");
}