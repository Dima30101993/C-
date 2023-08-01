// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] randomArray = new int[8];

Array(randomArray);

void Array(int[] ranA)
{
    for (int i = 0; i < 8; i++)
    {
        ranA[i] = new Random().Next(1,999);
        Console.Write($"{ranA[i]} ");
    }
}