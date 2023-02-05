/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"A = ({x1} {y1} {z1}) ");
Console.WriteLine($"B = ({x2} {y2} {z2}) ");

double p = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
p = Math.Round(p, 2);
Console.WriteLine($"Расстояние между (А) и (В) = {p}");