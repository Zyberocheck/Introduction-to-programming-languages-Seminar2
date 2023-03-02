// Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли первое число 
// кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int numberB = Convert.ToInt32(Console.ReadLine());

// if ( numberA % numberB == 0)
// Console.WriteLine( numberA + " кратно " + numberB);
// else {

// Console.WriteLine ( numberA + " некратно " + numberB);
// Console.WriteLine ("Остаток от деления: " + numberA % numberB );
// }

string result = numberA % numberB == 0 ? "Первое число кратно второму" : $"Первое некратно второму. Остаток от деления = {numberA % numberB}";

Console.WriteLine(result);






// Задача №14.
// Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Console.WriteLine(" Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number % 7 == 0 && number % 23 == 0 )
// Console.WriteLine(number + " кратно одновременно 7 и 23 ");
// else 
// Console.WriteLine (number + " не кратно одновременно 7 и 23 ");



