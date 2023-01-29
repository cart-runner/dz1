//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.WriteLine("Чётные числа от 1 до "+ number);
while (a <= number)
{
    if (a % 2 != 1)
 {
    Console.Write(a + ", ");
                    
 }
    a++;
}

           