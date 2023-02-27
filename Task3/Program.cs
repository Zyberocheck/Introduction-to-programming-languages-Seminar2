// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да



// Console.ReadLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.ReadLine("Введите 2 число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if ( number1 % number2 == 0)
// Console.WriteLine( number1 + " кратно " + number2);
// else {

// Console.WriteLine ( number1 " некратно " + number2);
// Console.WriteLine " Остаток от деления: " + number1 % number2 );
// }


Console.ReadLine(" Введите число ");
int number = Convert.ToInt32(Console.ReadLine());


if ( number % 7 == 0 && number % 23 == 0 )
Console.WriteLine(" кратно 7 и 23 ");
else 
Console.WriteLine (" не кратно 7 и 23 ");



