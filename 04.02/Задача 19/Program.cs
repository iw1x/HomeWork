/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число ");
int a = int.Parse(Console.ReadLine()!);

if (a < 10000 || a > 99999) Console.WriteLine("Нужно ввести пятизвачное число!");

else if (a / 10000 == a % 10) // первое число совпадает с последним
        if (a % 10000 / 1000 == a % 100 / 10) // второе число совпадает с предпоследним
        {
         Console.WriteLine($"{a} -> да");
        }
        else Console.WriteLine($"{a} -> нет");
    else Console.WriteLine($"{a} -> нет"); 

