// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();

Console.WriteLine($"Введите число ");
int a = int.Parse(Console.ReadLine()!);

if (a%2==0)
{
   Console.WriteLine($"{a} -> да "); 
}
else Console.WriteLine($"{a} -> нет "); 