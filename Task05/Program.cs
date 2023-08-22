// Задание развернуть массив

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

// void ReverseArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 -i];
//         arr[arr.Length - 1 - i] = temp;
//     }
// }

// int[] array = CreateArrayRndInt(5, 1, 9);
// PrintArray(array);
// Console.WriteLine();

// ReverseArray(array);
// PrintArray(array);


// Задача 40 Напишите программу которая принимает на вход три числа
// и проверяет может ли существовать треугольник
// со сторонами такой длинны

// bool IsExistTriangle(int a, int b, int c)
// {
//     if ((a < b + c) && (b < a + c) && (c < b + a)) return true;
//     else return false;
// }

// Console.WriteLine("Введите первую сторону треугольника:");
// int side1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую сторону треугольника:");
// int side2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третью сторону треугольника:");
// int side3 = Convert.ToInt32(Console.ReadLine());

// bool isExistTriangle = IsExistTriangle(side1, side2, side3);
// Console.WriteLine(isExistTriangle ? "да" : "нет");

// Задача 42. Напишите программу, которая
// будет преобразовывать десятичное число в двоичное

// int TransformationNumber(int num)
// {
//     int outNum = 0;
//     int i = 0;
//     while (num > 0)
//     {
//         outNum += num % 2 * (int)Math.Pow(10, i);
//         num /= 2;
//         i++;
//     } 
//     return outNum;
// }

// Console.WriteLine("Введите преобразумое десятичное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = TransformationNumber(number);
// Console.WriteLine(result);


// Задача 44. Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа 0 и 1.


// Console.WriteLine("Введите натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] CreateFibonacciArray(int num)
// {
//     int[] array = new int[num];
//     // array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < num; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//         i++;
//     }
//     return array;
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

// int[] result = CreateFibonacciArray(number);
// PrintArray(result);

