// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }

}

void RowSmallSumElements(int[,] matrix)
{
    int[] sumInLines = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumInLines[i] += matrix[i, j];
        }
    }
    int minI = 0;
    for (int i = 0; i < sumInLines.Length; i++)
    {
        if (sumInLines[minI] > sumInLines[i]) minI = i;
    }
    Console.Write($"\nНаименьшая сумма элементов: {sumInLines[minI]}, номер строки: {minI + 1}");
}

int[,] array2d = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();

RowSmallSumElements(array2d);