// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int num = rand.Next(100, 1000);
Console.WriteLine(num);
Console.WriteLine($"{num / 100}{num % 10}");

Random rand = new Random();
int num = rand.Next(100, 1000);
Console.WriteLine("Сгенерировано число " + num);
int a = num / 100;
int b = num % 10;
Console.Write(a);
Console.Write(b);





// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет



Console.WriteLine("Введите 2 числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine(numberA + " является квадратом числа " + numberB);
} else 
    if (numberB == numberA * numberA)
    {
        Console.WriteLine(numberB + " является квадратом числа " + numberA);
    } else
    {
        Console.WriteLine("Ни одно число не является квадратом другого");
    }
