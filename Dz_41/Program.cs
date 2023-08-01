// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число:");
Console.Write("Число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
Console.Write("Число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");

int Degree(int numA, int numB)
{
    int res = 1;
    for (int i = 0; i < Math.Abs(numB); i++)
    {
        res *= numA;
    }
    return res;
}
