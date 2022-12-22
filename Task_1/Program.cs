using static System.Console;

WriteLine("Введите число 1: ");
int number_1 = int.Parse(ReadLine()!);
WriteLine("Введите число 2: ");
int number_2 = int.Parse(ReadLine()!);

if (number_1 > number_2)
{
    Write("Наименьшее число: ");
    WriteLine(number_2);
    Write("Наибольшее число: ");
    WriteLine(number_1);
}
else
{
    Write("Наименьшее число: ");
    WriteLine(number_1);
    Write("Наибольшее число: ");
    WriteLine(number_2);
}