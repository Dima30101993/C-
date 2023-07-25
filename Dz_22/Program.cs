// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    int finish = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} -> {finish}");

}

int ThirdDigit(int dg)
{
    int absNumber = Math.Abs(dg); 
    string str = absNumber.ToString(); //решил немного поэксперементировать со строками, так как я питонист просьба камнями не кидать))))
    int thirdDigit = (int)Char.GetNumericValue(str[2]);
    return thirdDigit;
}