//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

Console.Clear();
Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter number3: ");
int number3 = int.Parse(Console.ReadLine());

int max = Max(number1, number2, number3);

Console.WriteLine($"Максимальное из чисел {number1}, {number2}, {number3} является {max}");


