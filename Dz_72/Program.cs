// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
    int[,] matrix = new int[rows, columns];
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine(); 
    }
    
}

void SearchElement(int[,] matrix) 
{
    Console.Write("Введите индекс строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());
    
    if (n >= 0 && m >= 0)
    {
    if (n < matrix.GetLength(0) && m < matrix.GetLength(1)) Console.WriteLine(matrix[n, m]);
    else Console.WriteLine($"{n}{m} -> такого числа в массиве нет");
    }
    else Console.WriteLine("Введен неверный(отрицательный) индекс, повторите попытку");
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();
SearchElement(array2d);
