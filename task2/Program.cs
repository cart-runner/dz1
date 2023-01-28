//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = 0;
if(numberB > max) 
{
    max = numberB;
    min = numberA;
}
else
{
    max = numberA;
    min = numberB;
}
Console.WriteLine($"максимальное число: {max}");
Console.WriteLine($"минимальное число: {min}");