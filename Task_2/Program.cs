//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1 ){
    Console.WriteLine($"Максимальное из чисел {number1} и {number2} является {number2}");
}
else{
    Console.WriteLine($"Максимальное из чисел {number1} и {number2} является {number1}");
}
