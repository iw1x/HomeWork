// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Clear();

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num>7)
{
    Console.WriteLine("В неделе всего 7 дней!");
}

else if (num < 6)
{
    Console.WriteLine($"{num} -> нет");
}
else Console.WriteLine($"{num} -> да");