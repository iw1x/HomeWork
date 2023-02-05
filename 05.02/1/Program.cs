// Подсчитать сумму цифр в числе 
// 6547 => 6 + 5 + 4 + 7 = 22
// 6547 => 7 + 4 + 5 + 6 = 22
//6547 % 10 = нужно делить на 10 до тех пор, пока не останется одно число


Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num % 10;
int sum = 0;

while (num / 10 != 0)
{
    num = num / 10;
    sum = sum + num % 10;
}
Console.WriteLine(sum+num1);
