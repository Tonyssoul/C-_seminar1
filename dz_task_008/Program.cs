// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число N ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
    for (int i = 2; i <= number; i += 2)
    {
        System.Console.Write(i + " ");
    }
}
else
{
   
    System.Console.Write("Введеное число меньше 1го");
    
}