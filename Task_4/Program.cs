using static System.Console;

WriteLine("Введите число: ");
int number_1 = int.Parse(ReadLine()!);
int n = number_1 - 1;
while (n > 1)
{
    if (n % 2 == 0)
    {
        Write($"{n} ");
    }
    n--;
}