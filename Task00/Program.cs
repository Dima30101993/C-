// Напишите программу, которая на вход
// принимает число и выдает его квадрат

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа {number} = {square}");

// Напишите программу, которая на вход 
// принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// а = 25, б = -5 -> да
// а = 2, б = 10 -> нет

// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number2 == number1 * number1)
// {
//     Console.WriteLine("Квадрат первого числа равен второму числу");
// }
// else
// {
//     Console.WriteLine("Квадрат первого числа не равен второму числу");
// }

// Напишите программу которая будет выдавать день недели
// в соответствии с введенным номером

// Console.WriteLine("Введите день недели");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day == 1)
// {
//     Console.WriteLine("День недели Понедельник");
// }
// else if (day == 2)
// {
//     Console.WriteLine("День недели Вторник");
// }
// else if (day == 2)
// {
//     Console.WriteLine("День недели Вторник");
// }
// else if (day == 3)
// {
//     Console.WriteLine("День недели Среда");
// }
// else if (day == 4)
// {
//     Console.WriteLine("День недели Четверг");
// }
// else if (day == 5)
// {
//     Console.WriteLine("День недели Пятница");
// }
// else if (day == 6)
// {
//     Console.WriteLine("День недели Суббота");
// }
// else if (day == 7)
// {
//     Console.WriteLine("День недели Воскресенье");
// }

// Напишите программу, которая на вход принимаетодно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N

// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // for(int i = -number; i <= number; i++)
// // {
// //     Console.Write($"{i} ");
// // }
// int count = -number;
// while(count <= number)
// {
//     Console.Write($"{count} ");
//     count++;
// }

// Напишите программу которая принимает на вход техзначное число
// и выводит на экран последнюю цифру

// Console.WriteLine("Введите трехзначное целое число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// {
//     number *= -1;
// }
// if (number >= 100 && number <=999)
// {
//     int result = number % 10;
//     Console.WriteLine($"Последняя цифра числа: {result}");
// }

