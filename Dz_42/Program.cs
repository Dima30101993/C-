// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(Math.Abs(number));
Console.WriteLine($"Сумма цифр в числе {number} -> {result}");

int SumNumbers(int num)
{
    int sum = 0;
    int ostatok = 0;
    while (num > 0)
    {
        ostatok = num % 10;
        sum += ostatok;
        num = num / 10;
    }
    return sum;
}