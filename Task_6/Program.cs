//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Enter number1: ");
int number = int.Parse(Console.ReadLine());
if(number%2==0)
{
    Console.WriteLine($"Введеное число {number} является четным");
}
else
{
    Console.WriteLine($"Введеное число {number} является нечетным");
}