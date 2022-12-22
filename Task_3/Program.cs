using static System.Console;

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);

WriteLine("Является ли число четным?");

if (number % 2 == 0)
{
    WriteLine("Да, является");
}
else
{
    WriteLine("Нет, не является");
}