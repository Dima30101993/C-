// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

Console.WriteLine("Введите пятизначное число: ");
Console.Write("Число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number > 9999 && Number < 100000)
{
    bool result = Pal(Number);
    Console.WriteLine(result 
                        ? "Является палиндромом" 
                        : "Не является палиндромом");
}
else
{
    Console.WriteLine("Введено неверное число");
}

bool Pal(int num)
{
   int number1 = num / 10000;
   int number2 = num / 1000 % 10;
   int number3 = num / 100 % 10;
   int number4 = num / 10 % 10;
   int number5 = num % 10;

    return number1 == number5 && number2 == number4;
}