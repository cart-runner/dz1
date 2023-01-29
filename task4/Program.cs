//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine($"максимальное число {max}");