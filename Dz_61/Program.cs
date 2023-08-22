// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateUserArray(int num)
{
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CheckArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите M чисел:");
int number = Convert.ToInt32(Console.ReadLine());

int[] result = CreateUserArray(number);
PrintArray(result);
Console.WriteLine();

int quantity = CheckArray(result);
Console.WriteLine($"Количество введеных чисел больше 0 = {quantity}");


