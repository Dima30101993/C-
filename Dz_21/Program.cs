// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > -1000)
{
    int secondDigit = ((number / 10) % 10);
    Console.WriteLine(Math.Abs(secondDigit));
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}