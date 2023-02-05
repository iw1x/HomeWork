// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();


Console.WriteLine($"Введите первое число ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите второе число ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите второе число ");
int num3 = int.Parse(Console.ReadLine()!);

int max = num1;

if (num2 > max)
{
    max=num2;
}

if (num3 > max)
{
    max=num3;
}
Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");