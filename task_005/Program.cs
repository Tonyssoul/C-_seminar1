// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N >99 && <1000)
{
    System.Console.WriteLine("Последняя цифра числа:" + N % 10);
}
else
{
    System.Console.WriteLine("Введено не трехзначное сило");
}
System.Console.WriteLine("Последняя цифра числа:" + N % 10);