// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



// Console.WriteLine("Введите номер дня недели: ");
// int dayweek = Convert.ToInt32(Console.ReadLine());
// switch (dayweek)
// {
//     case 1:
//     Console.WriteLine("Каждый Понидельник я как огурец");
// break;
//     case 2:
//     Console.WriteLine("Каждый Вторник я как огурец");
//  break;
//     case 3:
//     Console.WriteLine("Каждую Среду я как огурец");
//  break;
//     case 4:
//     Console.WriteLine("Каждый Четверг я как огурец");
//  break;
//     case 5:
//     Console.WriteLine("Каждую Пятницу я как огурец");
//  break;
//     case 6:
//     Console.WriteLine("Но каждую Субботу я в *****");
//  break;
//     case 7:
//     Console.WriteLine("И каждое Воскресенье я в *****");
//  break;
//     default:
//     Console.WriteLine("Нет такого номера их всего от 1 до 7! Попробуй еще раз!");
//     break;
// }
// if (dayweek <= 5)
// {
//     Console.WriteLine("Адский труд пролетария!!!");
// } else
// {
//     Console.WriteLine("И каждые выходные я в *****");
// }



Console.WriteLine("Введите номер дня недели: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
if (dayweek == 1)
{
    Console.WriteLine("Каждый Понидельник я как огурец");
} else if (dayweek == 2)
{
    Console.WriteLine("Каждый Вторник я как огурец");
} else if (dayweek == 3)
{
    Console.WriteLine("Каждую Среду я как огурец");
} else if (dayweek == 4)
{
    Console.WriteLine("Каждый Четверг я как огурец");
} else if (dayweek == 5)
{
    Console.WriteLine("Каждую Пятницу я как огурец");
} else if (dayweek == 6)
{
    Console.WriteLine("Но каждую Субботу я в *****");
} else if (dayweek == 7)
{
    Console.WriteLine("И каждое Воскресенье я в *****");
} else if (dayweek > 7)
{
    Console.WriteLine("Нет такого номера их всего от 1 до 7! Попробуй еще раз!");
}
