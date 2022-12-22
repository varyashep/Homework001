using static System.Console;

WriteLine("Введите число 1: ");
int number_1 = int.Parse(ReadLine()!);
WriteLine("Введите число 2: ");
int number_2 = int.Parse(ReadLine()!);
WriteLine("Введите число 3: ");
int number_3 = int.Parse(ReadLine()!);

int max = number_1;

if (number_1 > max)
{
    max = number_1;
}
if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max)
{
    max = number_3;
}

Write("Максимальное число: ");
WriteLine(max);