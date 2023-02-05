// Показать кубы чисел, заканчивающихся на четную цифру  2^3=8 4^3=64 6^3=216
int num = 99;
int a = 1;
int cub = 1;
while (a < num)
{
    cub = a * a * a;
        if (cub % 2 == 0)
            {
                Console.Write($"{cub} ");
            }
    a++;
}

