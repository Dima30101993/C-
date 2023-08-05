// Задайте массив из 12 элементов, заполненный
// случайными числами в промежутках [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateArrayRndInt(int size, int min, int max) 
// {
//     int[] arr = new int[size];
    
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//        else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// int[] GetSumPositiveNegativElem(int[] arr)
// {
//     int sumNegative = 0;
//     int sumPositive = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sumNegative += arr[i];
//         else sumPositive += arr[i];
//     }
//     return new int[]{sumNegative, sumPositive};
// }

// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)   
//     {
//         if(arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int GetSumNegativeElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)   
//     {
//         if(arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativElem[0]}");
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativElem[1]}");

// int sumNegativeElem = GetSumNegativeElem(array);
// int sumPositiveElem = GetSumPositiveElem(array);
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");

// Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные и наоборот

// int[] CreateArrayRndInt(int size, int min, int max) 
// {
//     int[] arr = new int[size];
    
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//        else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// void Return(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;  
//     }
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// Return(array);
// PrintArray(array);

// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве

// int[] CreateArrayRndInt(int size, int min, int max) 
// {
//     int[] arr = new int[size];
    
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//        else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// bool NumberinArray(int[] arr, int num)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num)
//         {
//             return true;
//             break;
//         } 
//     }
//     return false;
// }

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(NumberinArray(array, number)
//                             ? $"число {number} присутствует в данном массиве" 
//                             : $"число {number} отсутствует в данном массиве");