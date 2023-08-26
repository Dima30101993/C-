// Задача 46 Задайте двумерный массив размером m x n. 
// Заполненный случайными целыми числами

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
// {
//     int[,] matrix = new int[rows, columns];
    
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 6}");
//         }
//         Console.WriteLine(); 
//     }
    
// }

// int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(array2d);


// Задача 48. Задайте двумерный массив m на n,
// каждый элемент в массиве находится по формуле Amn = m + n.
// Выведите полученный массив на экран

// int[,] CreateMatrixSumIndexsis(int rows, int columns) 
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 6}");
//         }
//         Console.WriteLine(); 
//     }
    
// }

// int[,] array2d = CreateMatrixSumIndexsis(3, 4);
// PrintMatrix(array2d);


// Задача 49. Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные, и замените эти элементы на их квадраты.

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
// {
//     int[,] matrix = new int[rows, columns];
    
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 6}");
//         }
//         Console.WriteLine(); 
//     }
    
// }

// void ReplaceEventRowColumnsSquare(int[,] matrix) 
// {
//     for (int i = 0; i < matrix.GetLength(0); i += 2)
//     {   
//         for (int j = 0; j < matrix.GetLength(1); j += 2)
//         {
//            matrix[i, j] *= matrix[i, j];
//         }
//     }
// }

// int[,] array2d = CreateMatrixRndInt(3, 4, -1, 9);
// PrintMatrix(array2d);
// Console.WriteLine();

// ReplaceEventRowColumnsSquare(array2d); 
// PrintMatrix(array2d);
