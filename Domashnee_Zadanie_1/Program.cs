// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine("В армии Дайнерис бурерожденной: " + number + " драконов");
int numberA = number / 10 % 10;
if (numberA >= 0)
{
    Console.WriteLine("А нам она доравала только: " + numberA);
} else
{
    Console.WriteLine("Компухтер не даровал нам чисел(((");
}
