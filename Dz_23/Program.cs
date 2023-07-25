// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.


bool dayWeek(int day)
{
    return day ==7 || day == 6;
}
Console.WriteLine("Введите номер дня недели:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool result = dayWeek(dayNumber);
Console.WriteLine(result? "День является выходным!" : "День не является выходным!!!");











// if (dayNumber == 6 || dayNumber == 7)
// {
   
//     Console.WriteLine($"{dayText} -> Выходной день!");
// }
// else
// {
   
//     Console.WriteLine($"{dayText} -> Не выходной день!");
// }


