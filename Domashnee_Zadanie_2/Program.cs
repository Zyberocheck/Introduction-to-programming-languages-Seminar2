// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1000)
{
    while (number > 999)
    {
       number = number / 10;
    }    
        Console.WriteLine("Третья 1цифра: " + $"{number % 10}");  
} else if (number < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры");
} else
{
    Console.WriteLine("Третья 2цифра: " + $"{number % 10}");
}


    
